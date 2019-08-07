using System;
using _0208;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalculatorViewModel vm = new CalculatorViewModel();
            Assert.AreEqual(vm.Add(5, 3), 8);
        }
    }
}
