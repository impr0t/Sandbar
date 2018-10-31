using System;
using System.Threading;

using Sandbar;

namespace Sandbox
{
    internal class Program
    {
        #region Methods

        private static void Main(string[] args)
        {
            ProgressBarOptions opts = new ProgressBarOptions();
            opts.RunningColour = ConsoleColor.Yellow;
            opts.FinishedColour = ConsoleColor.Green;
            opts.Pattern = AnimationPattern.Balloon;
            opts.Interval = AnimationInterval.Short;
            

            using (var p = new ProgressBar("Doing Something", opts))
            {
                for (var i = 0; i < 100; i++)
                {
                    p.Report(i, 100);
                    Thread.Sleep(100);
                }
            }

            Console.ReadLine();
        }

        #endregion
    }
}