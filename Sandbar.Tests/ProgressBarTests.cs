using NUnit.Framework;
using Sandbar;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            ProgressBar b = new ProgressBar("Hello World!");
        }

        [Test]
        public void ConstructProgressBar()
        {
            
        }
    }
}