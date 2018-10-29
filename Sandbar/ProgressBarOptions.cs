using System;

namespace Sandbar
{
    public class ProgressBarOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBarOptions"/> class.
        /// </summary>
        public ProgressBarOptions()
        {
            BarWidth = ProgressBarWidth.Medium;
            Interval = AnimationInterval.Medium;
            Pattern = AnimationPattern.Bounce;
            ToProgressCharacter = ProgressCharacters.Dash;
            ProgressCharacter = ProgressCharacters.Arrow;
            RunningColour = ConsoleColor.Yellow;
            FinishedColour = ConsoleColor.Green;
            FinishedMessage = "Finished!";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBarOptions"/> class.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="pattern">The pattern.</param>
        public ProgressBarOptions(ProgressBarWidth width, TimeSpan interval, string pattern = "") : this()
        {
            BarWidth = width;
            Interval = interval;
            Pattern = pattern;
        }

        #region Properties

        /// <summary>
        /// Gets or sets the finished message to be displayed after the task has "completed".
        /// </summary>
        /// <value>
        /// The finished message.
        /// </value>
        public string FinishedMessage { get; set; }

        /// <summary>
        /// Gets or sets the running colour of the progress bar while the task is processing.
        /// </summary>
        /// <value>
        /// The running colour.
        /// </value>
        public ConsoleColor RunningColour { get; set; }

        /// <summary>
        /// Gets or sets the color of the finished message.
        /// </summary>
        /// <value>
        /// The finished colour.
        /// </value>
        public ConsoleColor FinishedColour { get; set; }

        /// <summary>
        /// Gets or sets the character that is used to indicate progress left.
        /// </summary>
        /// <value>
        /// To progress character.
        /// </value>
        /// <seealso cref="ProgressCharacters"/>
        public char ToProgressCharacter { get; set; }

        /// <summary>
        /// Gets or sets the character used to indicate progress completed.
        /// </summary>
        /// <value>
        /// The progress character.
        /// </value>
        /// <seealso cref="ProgressCharacters"/>
        public char ProgressCharacter { get; set; }

        /// <summary>
        /// Gets or sets the width of the bar.
        /// </summary>
        /// <value>
        /// The width of the bar.
        /// </value>
        /// <seealso cref="ProgressBarWidth"/>
        public ProgressBarWidth BarWidth { get; set; }

        /// <summary>
        /// Gets or sets the interval in which to update the bar.
        /// </summary>
        /// <value>
        /// The interval.
        /// </value>
        /// <seealso cref="AnimationInterval"/>
        public TimeSpan Interval { get; set; }

        /// <summary>
        /// Gets or sets the string character pattern to use when displaying a spinner beside the bar.
        /// </summary>
        /// <value>
        /// The pattern.
        /// </value>
        /// <seealso cref="AnimationPattern"/>
        public string Pattern { get; set; }

        #endregion
    }
}