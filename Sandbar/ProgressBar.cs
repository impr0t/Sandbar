using System;
using System.Text;
using System.Threading;

namespace Sandbar
{
    /// <summary>
    /// This project is an exension on the original console progress bar project released by DanielSWolf: https://github.com/DanielSWolf
    /// This project is under the MIT License: http://opensource.org/licenses/MIT
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    /// <seealso cref="System.IProgress{System.Double}" />
    public class ProgressBar : IDisposable, IProgress<double>
    {
        private readonly ProgressBarOptions _options;

        private readonly ConsoleColor _originalColor;

        private readonly Timer _timer;

        private int _animationIndex;

        private double _currentProgress;

        private string _currentText = string.Empty;

        private bool _disposed;

        public ProgressBar(string taskMessage)
        {
            _originalColor = Console.ForegroundColor;
            Console.Write(taskMessage);

            _timer = new Timer(TimerHandler);

            if (_options == null)
            {
                _options = new ProgressBarOptions();
            }

            if (!Console.IsOutputRedirected)
            {
                ResetTimer();
            }
        }

        public ProgressBar(string taskMessage, ProgressBarOptions options) : this(taskMessage)
        {
            _options = options;

            Console.ForegroundColor = _options.RunningColour;
        }

        #region Methods

        public void Dispose()
        {
            lock (_timer)
            {
                _disposed = true;

                Console.ForegroundColor = _options.FinishedColour;
                UpdateText(_options.FinishedMessage);
                Console.ForegroundColor = _originalColor;
                Console.WriteLine();
            }
        }

        public void Report(int currentStep, int maxSteps)
        {
            Report((double) currentStep / maxSteps);
        }

        public void Report(double value)
        {
            // Make sure value is in [0..1] range
            value = Math.Max(0, Math.Min(1, value));
            Interlocked.Exchange(ref _currentProgress, value);
        }

        private void ResetTimer()
        {
            _timer.Change(_options.Interval, TimeSpan.FromMilliseconds(-1));
        }

        private void TimerHandler(object state)
        {
            lock (_timer)
            {
                if (_disposed) return;

                var progressBlockCount = (int) (_currentProgress * (int) _options.BarWidth);
                var percent = (int) (_currentProgress * 100);

                var text = new StringBuilder();

                text.Append("[" +
                            $"{new string(_options.ProgressCharacter, progressBlockCount)}" +
                            $"{new string(_options.ToProgressCharacter, (int) _options.BarWidth - progressBlockCount)}" +
                            "] " +
                            $"{percent}% ");

                if (_options.Pattern.Length > 0)
                {
                    text.Append($"{_options.Pattern[_animationIndex++ % _options.Pattern.Length]}");
                }

                UpdateText(text.ToString());

                ResetTimer();
            }
        }

        private void UpdateText(string text)
        {
            // Get length of common portion
            var commonPrefixLength = 0;
            var commonLength = Math.Min(_currentText.Length, text.Length);

            while (commonPrefixLength < commonLength && text[commonPrefixLength] == _currentText[commonPrefixLength])
            {
                commonPrefixLength++;
            }

            // Backtrack to the first differing character
            var outputBuilder = new StringBuilder();

            outputBuilder.Append('\b', _currentText.Length - commonPrefixLength);

            // Output new suffix
            outputBuilder.Append(text.Substring(commonPrefixLength));

            // If the new text is shorter than the old one: delete overlapping characters
            var overlapCount = _currentText.Length - text.Length;

            if (overlapCount > 0)
            {
                outputBuilder.Append(' ', overlapCount);
                outputBuilder.Append('\b', overlapCount);
            }

            Console.Write(outputBuilder);
            _currentText = text;
        }

        #endregion
    }
}