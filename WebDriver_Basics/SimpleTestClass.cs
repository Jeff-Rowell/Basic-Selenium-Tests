using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjects
{
    [TestFixture]
    public class SimpleTestClass
    {
        //Chrome's proxy driver executable is in a folder already
        //on the host system's PATH environment variable.
        private IWebDriver _driver = new ChromeDriver();

        [Test]
        public void TestSiteHeaderIsOnHomePage()
        {
            _driver.Navigate().GoToUrl("http://saucelabs.com");
            IWebElement header = _driver.FindElement(By.Id("site-header"));
            Assert.True(header.Displayed);
            _driver.Close();
        }

        [Test]
        public void TestTitleIsGoogle()
        {
            //Navigate to basic Google page and get title
            _driver.Navigate().GoToUrl("http://Google.com");
            string expectedPageTitle = _driver.Title;
            string actualPageTitle = "Google";
            Assert.AreEqual(expectedPageTitle, actualPageTitle);
            _driver.Close();
        }
    }
}
