# Usage

API Highly likely to change.

```csharp
        private static void Main(string[] args)
        {
            ProgressBarOptions opts = new ProgressBarOptions();
            opts.RunningColour = ConsoleColor.Yellow;
            opts.FinishedColour = ConsoleColor.Green;
            opts.Pattern = AnimationPattern.Spinner;
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
```