using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpTests.POMs
{
    class CallBackPOM
    {
        IWebDriver _driver;
        public string ActSuccessText { get; }
        public CallBackPOM(IWebDriver driver)
        {
            this._driver = driver;
            ActSuccessText = "Сообщение успешно отправлено.";
        }
        string test_url = "https://makeup.com.ua/";
        By _inputName = By.CssSelector("body > form.form.form_callback.ajax.ng-pristine.ng-valid.active > div > div.form-inner-wrap > div:nth-child(2) > div > input");
        By _inputPhone = By.CssSelector("body > form.form.form_callback.ajax.ng-pristine.ng-valid.active > div > div.form-inner-wrap > div:nth-child(3) > div > input");
        By _textareaMessage = By.CssSelector("body > form.form.form_callback.ajax.ng-pristine.ng-valid.active > div > div.form-inner-wrap > div:nth-child(4) > div > textarea");
        By _buttonSend = By.CssSelector("body > form.form.form_callback.ajax.ng-pristine.ng-valid.active > div > div.form-inner-wrap > div:nth-child(5) > button");
        By _buttonCallBack = By.CssSelector("body > div.site-wrap > div.main-wrap > header > div.header-middle > div > div.header-contact > div.button");


        By _successText = By.CssSelector("#popup__window > div.popup-content > b");

        public void clickButtonSend()
        {
            _driver.FindElement(_buttonSend).Click();
        }
        public void clickButtonCallBack()
        {
            _driver.FindElement(_buttonCallBack).Click();
        }
        public void inputName(string text)
        {
            IWebElement waitButton = (new WebDriverWait(_driver, TimeSpan.FromSeconds(20))).Until(ExpectedConditions.ElementIsVisible(_inputName));
            IWebElement input = _driver.FindElement(_inputName);
            input.SendKeys(text);
        }
        public void inputPhone(string text)
        {
            IWebElement input = _driver.FindElement(_inputPhone);
            input.SendKeys(text);
        }
        public void inputMessage(string text)
        {
            IWebElement input = _driver.FindElement(_textareaMessage);
            input.SendKeys(text);
        }
        public string getActSuccessText()
        {
            IWebElement waitButton = (new WebDriverWait(_driver, TimeSpan.FromSeconds(20))).Until(ExpectedConditions.ElementIsVisible(_successText));
            return _driver.FindElement(_successText).Text;
        }
    }
}
