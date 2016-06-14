using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace WiniumCalculatorTests
{
    [TestClass]
    public class AddingNumbersTest : BaseTest
    {
        public IWebElement SubmitButton()
        {
            return MainWindow.FindElement(By.Id("submit"));
        }

        public IWebElement AnswerLabel()
        {
            return MainWindow.FindElement(By.Id("answer"));
        }

        public IWebElement NumberOne()
        {
            return MainWindow.FindElement(By.Id("numberOne"));
        }

        public IWebElement NumberTwo()
        {
            return MainWindow.FindElement(By.Id("numberTwo"));
        }

        [TestMethod]
        public void TestAddingPositiveNumbers()
        {
            Assert.AreEqual("answer me!", SubmitButton().GetAttribute("Name"));
            Assert.AreEqual("answer to be confirmed", AnswerLabel().GetAttribute("Name"));

            NumberOne().SendKeys("5");
            NumberTwo().SendKeys("2");

            SubmitButton().Click();

            Assert.AreEqual("7", AnswerLabel().GetAttribute("Name"));
        }
    }
}
