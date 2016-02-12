using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApplicationBusinessLayer;

namespace TestApplication
{
    [TestClass]
    public class TestApplication
    {
        [TestMethod]
        public void TestSuccess1()
        {
            string input = "This is a statement, and so is this.";
            string Result = "this-2\nis-2\na-1\nstatement-1\nand-1\nso-1";
            BusinessLogic objBusinessLogic = new BusinessLogic();
            string Output = objBusinessLogic.GetDistinctWordInASentence(input);
            Assert.AreEqual(Result, Output);
        }

        [TestMethod]
        public void TestSuccess2()
        {
            string input = "Hello, This is a test application to test distinct word in a sentence. :)";
            string Result = "hello-1\nthis-1\nis-1\na-2\ntest-2\napplication-1\nto-1\ndistinct-1\nword-1\nin-1\nsentence-1";
            BusinessLogic objBusinessLogic = new BusinessLogic();
            string Output = objBusinessLogic.GetDistinctWordInASentence(input);
            Assert.AreEqual(Result, Output);
        }

        [TestMethod]
        public void TestFail1()
        {
            string input = "This is a statement, and so is this.";
            string Result = "this-2\nis-2\na-1\nstatement-1\nand-1\nso-1";
            BusinessLogic objBusinessLogic = new BusinessLogic();
            string Output = objBusinessLogic.GetDistinctWordInASentence(input);
            Assert.AreNotEqual(Result, Output);
        }

        [TestMethod]
        public void TestFail2()
        {
            string input = "This is a statement, and so is this.";
            string Result = "1";
            BusinessLogic objBusinessLogic = new BusinessLogic();
            string Output = objBusinessLogic.GetDistinctWordInASentence(input);
            Assert.AreEqual(Result, Output);
        }
    }
}
