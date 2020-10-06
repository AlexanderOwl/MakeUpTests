using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpTests
{
    class SubscribeFormPOM
    {
        IWebDriver _driver;
        public string ActSuccessText { get; }
        public SubscribeFormPOM(IWebDriver driver)
        {
            this._driver = driver;
            ActSuccessText = "Вы успешно подписались на эту рассылку!";
        }
        string test_url = "https://makeup.com.ua/";
        By _inputEmail = By.CssSelector("body > div.site-wrap > footer > div > form > div.footer-input-row > div > input");
        By _buttonSubscribe = By.CssSelector("body > div.site-wrap > footer > div > form > div.footer-input-row > button");
        By _successText = By.CssSelector("#popup__window > div.popup-content > p");

        public void clickButtonSubscribe()
        {
            _driver.FindElement(_buttonSubscribe).Click();
        }

        public void inputEmail(string text)
        {
            IWebElement input = _driver.FindElement(_inputEmail);
            input.SendKeys(text);
        }
        public string getActSuccessText()
        {
            IWebElement waitButton = (new WebDriverWait(_driver, TimeSpan.FromSeconds(20))).Until(ExpectedConditions.ElementIsVisible(_successText));
            return _driver.FindElement(_successText).Text;
        }
    }
}
