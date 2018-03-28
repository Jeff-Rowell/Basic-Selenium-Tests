using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriver_Basics
{
    [TestFixture]
    public class simpleTestClass
    {

        [Test]
        public void TestSiteHeaderIsOnHomePage()
        {
            IWebDriver browser = new ChromeDriver(@"C:\Users\Jeff Rowell\Desktop\WebDriver_Basics\chromedriver_win32\");
            //Chrome's proxy driver executable is in a folder already
            //on the host system's PATH environment variable.
            browser.Navigate().GoToUrl("http://saucelabs.com");
            IWebElement header = browser.FindElement(By.Id("site-header"));
            Assert.True(header.Displayed);
            browser.Close();
        }

        [Test]
        public void TestTitleIsGoogle()
        {
            IWebDriver browser = new ChromeDriver(@"C:\Users\Jeff Rowell\Desktop\WebDriver_Basics\chromedriver_win32\");
            //Now navigate to basic Google page and get title
            browser.Navigate().GoToUrl("http://Google.com");
            string expectedPageTitle = browser.Title;
            string actualPageTitle = "Google";
            Assert.AreEqual(expectedPageTitle, actualPageTitle);
            browser.Close();
        }
    }
}
