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
        public IWebDriver driver = new ChromeDriver(@"packages\Selenium.WebDriver.ChromeDriver.85.0.4183.8700\driver\win32");
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

        /*
        [TestCase("name","TestTest")]
        public void ChangeUserData(string operation, string newText)
        {
            headerAccount.ClickCabinet();
            headerAccount.TypeUserLogin("test1313@mailinator.com");
            headerAccount.TypeUserPassword("1313");
            headerAccount.ClickLogInButton();

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(100);

            headerAccount.ClickCabinet();
            headerAccount.ChangeUserInfo(operation, newText);
            headerAccount.ClickSave();
            headerAccount.ClicClose();
            headerAccount.ReturnText(operation);

            Assert.Equals(headerAccount.ReturnText(operation), newText);
        }
        */



        [OneTimeTearDown]
        public void ClosePage()
        {
            driver.Quit();
        }
    }
}

