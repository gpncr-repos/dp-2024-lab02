using ConsoleApp4;
using NUnit.Framework.Internal;
using Logger = ConsoleApp4.Logger;

namespace Tests
{
    public class Tests
    {
        Logger? _logger;

        [SetUp]
        public void Setup()
        {
            ConsoleLogStrategy consoleLogStrategy = new ConsoleLogStrategy();
            _logger = new Logger("", "", consoleLogStrategy);
        }

        [Test]
        public void Test1()
        {
            ConsoleLogStrategy consoleLogStrategy = new ConsoleLogStrategy();

            consoleLogStrategy.Log("", "Test1");
            //Assert.Pass();
        }
    }
}