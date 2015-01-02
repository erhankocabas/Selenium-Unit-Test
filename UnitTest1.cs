using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace UnitTestSample
{
     [TestFixture]
    public class UnitTest1
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;

        [SetUp]
        public void SetupTest()
        {
            //Bu fonksyon test ortamını ayarlar.
            driver = new FirefoxDriver();
            //Test yapılacak sayfanın linki.
            baseURL = "https://www.google.com.tr/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Browser kapanırsa hataları görmezden gel
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUnitTest1Test()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Id("gbqfq")).Clear();
            driver.FindElement(By.Id("gbqfq")).SendKeys("İstanbul boya fiyatları");
            driver.FindElement(By.Id("gbqfb")).Click();
        }
       
    }
}
