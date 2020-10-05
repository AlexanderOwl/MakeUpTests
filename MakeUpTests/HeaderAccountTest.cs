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
   public class HeaderAccountTest
    {
        public IWebDriver driver = new ChromeDriver(@"D:\chromedriver_win32\");
        HeaderAccountPOM headerAccount;

        public HeaderAccountTest()
        {
            driver.Navigate().GoToUrl("https://makeup.com.ua/");
            driver.Manage().Window.Maximize();
            headerAccount = new HeaderAccountPOM(driver);
        }

        [Test]
        public void AutorizationWithValidData()
        {
            headerAccount.ClickCabinet();
            headerAccount.TypeUserLogin("test1313@mailinator.com");
            headerAccount.TypeUserPassword("1313");
            headerAccount.ClickLogInButton();

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(100);

            Assert.AreEqual("Кабинет", headerAccount.NameAccount());
        }




        [OneTimeTearDown]
        public void ClosePage()
        {
            driver.Quit();
        }
    }
}

