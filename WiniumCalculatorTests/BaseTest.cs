using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace WiniumCalculatorTests
{
    public class BaseTest
    {
        public RemoteWebDriver Driver { get; set; }
        public IWebElement MainWindow { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            var driverCapabilities = new DesiredCapabilities();
            driverCapabilities.SetCapability("app", @"C:\Users\dev\Desktop\MyCalculator\MyCalculator\bin\Release\MyCalculator.exe");
            Driver = new RemoteWebDriver(new Uri("http://localhost:9999"), driverCapabilities);

            MainWindow = Driver.FindElementById("Form1");
        }

        [TestCleanup]
        public void Cleanp()
        {
            Driver.Close();
        }
    }
}
