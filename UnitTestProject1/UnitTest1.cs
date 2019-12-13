using Microsoft.VisualStudio.TestTools.UnitTesting;

using GameWeb;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly TestClass _testClass;

        public UnitTest1()
        {
            _testClass = new TestClass();
        }

        [TestMethod]
        public void TestClass_Calculate()
        {
            int result = _testClass.Calculate();

            Assert.IsNotNull(result, "Result of the unit test result");
        }
    }
}
