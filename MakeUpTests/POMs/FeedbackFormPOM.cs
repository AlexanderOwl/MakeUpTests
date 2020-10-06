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
        public string ActSuccessText { get; }
        public FeedbackFormPOM(IWebDriver driver)
        {
            this._driver = driver;
            ActSuccessText  = "Дякуємо, ваше повідомлення надіслано!";
        }
        string test_url = "https://makeup.com.ua/feedback/";
        By _dropdownDepartment = By.CssSelector("#form-feedback > div.form-wrap > div:nth-child(2) > div > div.custom-select__value-wrap");
        By _buttonSubmit = By.CssSelector("#form-feedback > div.form-wrap > div:nth-child(7) > button");
        By _inputName = By.Id("contacts-name");
        By _inputEmail = By.Id("contacts-email");
        By _inputSubj = By.Id("contacts-subj");
        By _inputMessage = By.Id("contacts-message");
        By _successText = By.CssSelector("#popup__window > div.popup-content");
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
            _driver.FindElement(_dropdownDepartment).Click();
            _driver.FindElement(By.CssSelector("#form-feedback > div.form-wrap > div:nth-child(2) > div > div.custom-select__popup > div > div:nth-child(2)")).Click();
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
        public string getActSuccessText()
        {
            IWebElement waitButton = (new WebDriverWait(_driver, TimeSpan.FromSeconds(20))).Until(ExpectedConditions.ElementIsVisible(_successText));
            return _driver.FindElement(_successText).Text;
        }
        
    }
}
