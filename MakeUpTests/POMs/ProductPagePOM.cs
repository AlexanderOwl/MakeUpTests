using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpTests
{
    class ProductPagePOM
    {
        IWebDriver _driver;
        public ProductPagePOM(IWebDriver driver)
        {
            this._driver = driver;

        }
        string test_url = "https://makeup.com.ua/product/8383/";
        By _buttonBuy = By.CssSelector("body > div.site-wrap > div.main-wrap > div > div > div:nth-child(2) > div.product-item > div > div.product-item__buy > div.product-item__button > div");
        By _buttonIncrease = By.CssSelector("body > div.popup.cart.ng-animate.ng-hide-animate > div > div.popup-content > div.product-list-wrap > ul > li > div > div.product__count-list > div.product__button-increase");
        By _totalPrice = By.CssSelector("body > div.popup.cart.ng-animate.ng-hide-animate > div > div.popup-content > div.product-list__result > div.total > span > strong");
        By _price = By.CssSelector("body > div.site-wrap > div.main-wrap > div > div > div:nth-child(2) > div.product-item > div > div.product-item__buy > div.product-item__row > div.product-item__price-wrap > span.product-item__price > div > span");
        By _buttonOrder = By.CssSelector("body > div.popup.cart.ng-animate.ng-hide-animate > div > div.popup-content > div.cart-controls > div:nth-child(1) > div");
        public void goToPage()
        {
            _driver.Navigate().GoToUrl(test_url);
        }
        public void clickButtonOrder()
        {
            IWebElement waitButton = (new WebDriverWait(_driver, TimeSpan.FromSeconds(20))).Until(ExpectedConditions.ElementToBeClickable(_buttonOrder));

            _driver.FindElement(_buttonOrder).Click();
        }
        public void clickButtonBuy()
        {
            _driver.FindElement(_buttonBuy).Click();

        }
        public void clickButtonIncrease()
        {
            _driver.FindElement(_buttonIncrease).Click();

        }
        public double returnTotalPrice()
        {
            return double.Parse(_driver.FindElement(_totalPrice).Text);            
        }
        public double returnPrice()
        {
            return double.Parse(_driver.FindElement(_price).Text);            
        }
     
    }
}
