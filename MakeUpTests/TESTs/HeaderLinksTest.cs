using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpTests
{
  public  class HeaderLinksTest
    {
        public IWebDriver driver = new ChromeDriver(@"packages\Selenium.WebDriver.ChromeDriver.85.0.4183.8700\driver\win32");
        HeaderLinksPOM headerLinks;


        public HeaderLinksTest()
        {
            driver.Navigate().GoToUrl("https://makeup.com.ua/");
            driver.Manage().Window.Maximize();
            headerLinks = new HeaderLinksPOM(driver);
        }

        [TestCase("promotion", "https://makeup.com.ua/actions/")]
        [TestCase("beatyClub", "https://makeup.com.ua/about/23/")]
        [TestCase("delivery", "https://makeup.com.ua/delivery/")]
        [TestCase("article", "https://makeup.com.ua/articles/")]
        [TestCase("aboutShop", "https://makeup.com.ua/about/")]
        public void NavigateToHeaderLinks(string link, string expected)
        {
            headerLinks.CheckLinkHeader(link);
            string actual = driver.Url;
            Assert.AreEqual(expected, actual);
        }


        [OneTimeTearDown]
        public void ClosePage()
        {
            driver.Quit();
        }
    }
}
