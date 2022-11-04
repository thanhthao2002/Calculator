using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;


namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        Calculation cal;
        [TestInitialize]
        public void SetUp()
        {
            cal = new Calculation(10, 5);
            Assert.AreEqual(15, cal.Execute("+"));
        }
        [TestMethod]
        public void TestAddOperation()
        { //10+5-->15
            Assert.AreEqual(15, cal.Execute("+"));
        }
        [TestMethod]
        public void TestSubOperation()
        { 
            Assert.AreEqual(5, cal.Execute("-"));
        }
        [TestMethod]
        public void TestMulOperation()
        { 
            Assert.AreEqual(50, cal.Execute("*"));
        }
        [TestMethod]
        public void TestDivOperation()
        { 
            Assert.AreEqual(2, cal.Execute("/"));
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(10, 0);
            c.Execute("/");

        }
    }
}
