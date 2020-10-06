using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpTests.POMs
{
    class CheckOutPOM
    {

        IWebDriver _driver;
        public string titleText { get; }
        public string CompleteUrl = "https://makeup.com.ua/checkout/complete/";
        public CheckOutPOM(IWebDriver driver)
        {
            this._driver = driver;
            titleText = "Оформление заказа на MAKEUP";
        }
       
        
        By _inputName = By.Id("name");
        By _inputSurname = By.Id("surname");
        By _inputPhone = By.Id("phone");
        By _inputEmail = By.Id("email");
        By _inputCity = By.Id("city");
        By _inputStreet = By.Id("street");
        By _inputHome = By.Id("home");
        By _checkDontCall = By.CssSelector("#checkout-form > div.checkout__steps-tab.checkout__steps-tab2 > div:nth-child(2) > div:nth-child(7) > span > label");
        By _cityItem = By.CssSelector("#shipping_city > div > div > ul > li.search-value__list_item.selected");
        By _streetItem = By.CssSelector("#shipping_address > div:nth-child(1) > div > div > ul > li");
        
        By _buttonNext = By.CssSelector("#checkout-form > div.checkout__steps-tab.checkout__steps-tab1 > div:nth-child(2) > div.checkout__row.next-row > label");
        By _buttonSubmit = By.CssSelector("#checkout-form > div.checkout__steps-tab.checkout__steps-tab2 > div:nth-child(2) > div:nth-child(12) > button");
        By _successText = By.CssSelector("body > div.site-wrap > div.main-wrap > div > div > div > h1");

        public void clickButtonNext()
        {
            _driver.FindElement(_buttonNext).Click();

        }
        public void clickStreetItem()
        {
            IWebElement waitButton = (new WebDriverWait(_driver, TimeSpan.FromSeconds(20))).Until(ExpectedConditions.ElementToBeClickable(_streetItem));
            _driver.FindElement(_streetItem).Click();

        }
        public void clickCityItem()
        {
            IWebElement waitButton = (new WebDriverWait(_driver, TimeSpan.FromSeconds(20))).Until(ExpectedConditions.ElementToBeClickable(_cityItem));
            _driver.FindElement(_cityItem).Click();

        }
        public void chekDontCall()
        {
            _driver.FindElement(_checkDontCall).Click();
        }
        public void clickButtonSubmit()
        {
            IWebElement waitButton = (new WebDriverWait(_driver, TimeSpan.FromSeconds(5))).Until(ExpectedConditions.ElementToBeClickable(_buttonSubmit));

            _driver.FindElement(_buttonSubmit).Click();

        }
        public void inputName(string text)
        {
            IWebElement waitButton = (new WebDriverWait(_driver, TimeSpan.FromSeconds(5))).Until(ExpectedConditions.ElementIsVisible(_inputName));
            IWebElement input = _driver.FindElement(_inputName);
            input.SendKeys(text);
        }
        public void inputPhone(string text)
        {
            IWebElement input = _driver.FindElement(_inputPhone);
            input.SendKeys(text);
        }
        public void inputSurname(string text)
        {
            IWebElement input = _driver.FindElement(_inputSurname);
            input.SendKeys(text);
        }
        public void inputEmail(string text)
        {
            IWebElement input = _driver.FindElement(_inputEmail);
            input.SendKeys(text);
        }
        public void inputCity(string text)
        {
            IWebElement waitButton = (new WebDriverWait(_driver, TimeSpan.FromSeconds(5))).Until(ExpectedConditions.ElementToBeClickable(_inputCity));
            IWebElement input = _driver.FindElement(_inputCity);
            input.SendKeys(text);
        }
        public void inputHome(string text)
        {
            IWebElement waitButton = (new WebDriverWait(_driver, TimeSpan.FromSeconds(5))).Until(ExpectedConditions.ElementToBeClickable(_inputHome));

            IWebElement input = _driver.FindElement(_inputHome);
            input.SendKeys(text);
        }
        public void inputStreet(string text)
        {
            IWebElement waitButton = (new WebDriverWait(_driver, TimeSpan.FromSeconds(5))).Until(ExpectedConditions.ElementToBeClickable(_inputStreet));
            IWebElement input = _driver.FindElement(_inputStreet);
            input.SendKeys(text);
        }
        
    }
}
