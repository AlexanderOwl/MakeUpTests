using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpTests
{
    class FeedbackFormPOM
    {
        IWebDriver _driver;
        public FeedbackFormPOM(IWebDriver driver)
        {
            this._driver = driver;

        }
        string test_url = "https://makeup.com.ua/feedback/";
        By _dropdownDepartment = By.CssSelector("#form-feedback > div.form-wrap > div:nth-child(2) > select");
        By _buttonSubmit = By.CssSelector("#form-feedback > div.form-wrap > div:nth-child(7) > button");
        By _inputName = By.Id("contacts-name");
        By _inputEmail = By.Id("contacts-email");
        By _inputSubj = By.Id("contacts-subj");
        By _inputMessage = By.Id("contacts-message");
      
        public void goToPage()
        {
            _driver.Navigate().GoToUrl(test_url);
        }
        public void clickButtonSubmit()
        {
            _driver.FindElement(_buttonSubmit).Click();
        }
        public void selectDepartment(int id)
        {
            IWebElement dropdownDepartment = _driver.FindElement(_dropdownDepartment);
            var selectElementDepatment = new SelectElement(dropdownDepartment);
            selectElementDepatment.SelectByIndex(id);
        }
        public void inputName(string text)
        {
            IWebElement input = _driver.FindElement(_inputName);
            input.SendKeys(text);            
        }
        public void inputEmail(string text)
        {
            IWebElement input = _driver.FindElement(_inputEmail);
            input.SendKeys(text);
        }
        public void inputSubj(string text)
        {
            IWebElement input = _driver.FindElement(_inputSubj);
            input.SendKeys(text);
        }
        public void inputMessage(string text)
        {
            IWebElement input = _driver.FindElement(_inputMessage);
            input.SendKeys(text);
        }
    }
}
