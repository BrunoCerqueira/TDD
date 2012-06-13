using ES1TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace TestTDD
{
    [TestClass()]
    public class CupomTest
    {


        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        [TestMethod()]
        public void IsValidoTestTrue()
        {
            Cupom cupom = new Cupom("500036532-7");
            Assert.IsTrue(cupom.IsValido());
        }

        [TestMethod()]
        public void IsValidoTestFalse()
        {
            Cupom cupom = new Cupom("500036532-8");
            Assert.IsFalse(cupom.IsValido());
        }

        [TestMethod()]
        public void getPotzTest()
        {
            Cupom cupom = new Cupom("500036532-7");
            Assert.AreEqual(cupom.getPotz(), 500);
        }

        [TestMethod()]
        public void getPotzTest2()
        {
            Cupom cupom = new Cupom("400036532-7");
            Assert.AreEqual(cupom.getPotz(), 400);
        }
    }
}
