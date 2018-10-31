using System;

using NUnit.Framework;

namespace Sandbar.Tests
{
    [TestFixture]
    public class ProgressBarOptionsTests
    {
        [Test]
        public void AllValuesSetOnDefaultConstruction()
        {
            var opts = new ProgressBarOptions();
            Assert.NotNull(opts.BarWidth);
            Assert.NotNull(opts.FinishedColour);
            Assert.NotNull(opts.RunningColour);
            Assert.NotNull(opts.FinishedMessage);
            Assert.NotNull(opts.Interval);
            Assert.NotNull(opts.Pattern);
            Assert.NotNull(opts.ProgressCharacter);
            Assert.NotNull(opts.ToProgressCharacter);
        }

        [Test]
        public void ProperBarWidthSetOnConstruction()
        {
            var opts = new ProgressBarOptions();
            Assert.AreEqual(opts.BarWidth, ProgressBarWidth.Medium);
        }

        [Test]
        public void ProperFinishedColorSetOnDefaultConstruction()
        {
            var opts = new ProgressBarOptions();
            Assert.AreEqual(opts.FinishedColour, ConsoleColor.Green);
        }

        [Test]
        public void ProperRunningColorSetOnDefaultConstruction()
        {
            var opts = new ProgressBarOptions();
            Assert.AreEqual(opts.RunningColour, ConsoleColor.Yellow);
        }
    }
}