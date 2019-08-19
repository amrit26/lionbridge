using Lionbridge.Tasks.Concrete;
using NUnit.Framework;

namespace Lionbridge.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_TaskA_AreSame()
        {
            var taskA = new A();
            var result = taskA.RunAllTasksExceptE();
            var expected = "All tasks but ran, except E.";
            Assert.AreSame(expected, result);
        }

        [TestCase("Run D.")]
        [Test]
        public void Test_TaskB_RunD_AreSame(string expected)
        {
            var taskB = new B();
            var result = taskB.RunD();
            Assert.AreSame(expected, result);
        }

        [TestCase("Run E.")]
        [Test]
        public void Test_TaskB_RunE_AreSame(string expected)
        {
            var taskB = new B();
            var result = taskB.RunE();
            Assert.AreSame(expected, result);
        }

        [TestCase("Run E then Run C.")]
        [Test]
        public void Test_TaskC_RunEFirstThenC_AreSame(string expected)
        {
            var taskC = new C();
            var result = taskC.RunE();
            Assert.AreSame(expected, result);
        }

        [TestCase("Run C.")]
        [Test]
        public void Test_TaskC_RunC_AreSame(string expected)
        {
            var taskC = new C();
            var result = taskC.RunC();
            Assert.AreSame(expected, result);
        }

        [TestCase("Run D.")]
        [Test]
        public void Test_TaskD_RunD_AreSame(string expected)
        {
            var taskD = new D();
            var result = taskD.RunD();
            Assert.AreSame(expected, result);
        }

        [TestCase("Run E. No other dependency.")]
        [Test]
        public void Test_TaskE_RunC_AreSame(string expected)
        {
            var taskE = new E();
            var result = taskE.RunE();
            Assert.AreSame(expected, result);
        }
    }
}
