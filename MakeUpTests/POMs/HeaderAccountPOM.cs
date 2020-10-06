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

        // User page
        By _fieldUserName = By.Id("name");
        By _fieldUserLastName = By.Id("surname");
        By _buttonSave = By.CssSelector("body > div.site-wrap > div.main-wrap > div > div > div > div > form > div:nth-child(2) > div:nth-child(5) > button");
        By _saveMessage = By.CssSelector("#popup__window > div.popup-content > p");
        By _closeMessage = By.CssSelector("# popup__window > div.popup-close.close-icon");

        public HeaderAccountPOM(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void ChangeUserInfo(string operation, string text)
        {
            switch (text)
            {
                case "name":
                    driver.FindElement(_fieldUserName).SendKeys(text);
                    break;
                case "lastName":
                    driver.FindElement(_fieldUserLastName).SendKeys(text);
                    break;
            }
        }

        public void ClickSave()
        {
            driver.FindElement(_buttonSave).Click();        
        }

        public void ClicClose()
        {
            driver.FindElement(_closeMessage).Click();
        }

        public string ReturnText(string operation)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement element=null;
            switch (operation)
            {
                case "name":
                    element = driver.FindElement(_fieldUserName);
                    break;
                case "lastName":
                    element = driver.FindElement(_fieldUserLastName);
                    break;
                case "saveMessage":
                    element = driver.FindElement(_saveMessage);
                    break;

            }
            return element.Text;
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
         
            return nameAccount;
        }


        public HeaderAccountPOM ClickRegistration()
        {
            driver.FindElement(_registration).Click();
            return this;
        }

    }
}
