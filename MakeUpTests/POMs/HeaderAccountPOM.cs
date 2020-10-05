using OpenQA.Selenium;
using System;

namespace MakeUpTests
{
    public class HeaderAccountPOM
    {
        IWebDriver driver;

        By _cabinet = By.XPath("/html/body/div[1]/div[1]/header/div[1]/div/div[3]/div");
        By _loginField = By.Name("user_login");
        By _passwordField = By.Name("user_pw");
        By _logInButton = By.CssSelector("#form-auth > div > div.form-inner-wrap > div:nth-child(4) > button");
        By _enter = By.CssSelector("body > div.site-wrap > div.main-wrap > header > div.header-top > div > div:nth-child(3) > a");

        By _registration = By.ClassName("auth-link");
        public HeaderAccountPOM(IWebDriver driver)
        {
            this.driver = driver;
        }


        public HeaderAccountPOM ClickCabinet()
        {
            driver.FindElement(_cabinet).Click();
            return this;
        }


        public HeaderAccountPOM TypeUserLogin(string login)
        {
            driver.FindElement(_loginField).SendKeys(login);
            return this;
        }

        public HeaderAccountPOM TypeUserPassword(string password)
        {
            driver.FindElement(_passwordField).SendKeys(password);
            return this;
        }


        public HeaderAccountPOM ClickLogInButton()
        {
            driver.FindElement(_logInButton).Click();
            return this;
        }


        public string NameAccount()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement element = driver.FindElement(_enter);
            string nameAccount = element.Text;
          //  string nameAccount = driver.FindElement(_enter).Text;
            return nameAccount;
        }


        public HeaderAccountPOM ClickRegistration()
        {
            driver.FindElement(_registration).Click();
            return this;
        }

    }
}
