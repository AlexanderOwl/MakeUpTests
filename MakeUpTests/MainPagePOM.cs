using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpTests
{
    public class MainPagePOM
    {
        IWebDriver _driver;
        public MainPagePOM(IWebDriver driver)
        {
            this._driver = driver;
        }
        string test_url = "https://makeup.com.ua/";
        By _menuItem_Parfums = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(1) > a");
        By _menuItem_MakeUp = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(2)");
        By _menuItem_Nails = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(3)");
        By _menuItem_Hair = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(4)");
        By _menuItem_Face = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(5)");
        By _menuItem_BodyAndBath = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(6)");
        By _menuItem_Mens = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(7)");
        By _menuItem_Acssesories = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(8)");
        By _menuItem_HealthAndCare = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(9)");
        By _menuItem_Gift = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(10)");


        By _menuItem_Brands = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(11)");
        By _inputSearch = By.Id("search-input");
        By _headerBasket = By.ClassName("header-basket");
        By _buttonCallBack = By.CssSelector("body > div.site-wrap > div.main-wrap > header > div.header-middle > div > div.header-contact > div.button");
        By _sliderNext = By.ClassName("slider-arrow-next");
        By _sliderPrev = By.ClassName("slider-arrow-prev");



        By _sliderItem1 = By.CssSelector("#slider > ul.slides > li:nth-child(2)");
        By _sliderItem2 = By.CssSelector("#slider > ul.slides > li:nth-child(3)");
        By _sliderItem3 = By.CssSelector("#slider > ul.slides > li:nth-child(4)");
        By _sliderItem4 = By.CssSelector("#slider > ul.slides > li:nth-child(5)");
        By _sliderItem5 = By.CssSelector("#slider > ul.slides > li:nth-child(6)");
        By _sliderItem6 = By.CssSelector("#slider > ul.slides > li:nth-child(7)");
        By _inputEmail = By.CssSelector("body > div.site-wrap > footer > div > form > div.footer-input-row > div > input");
        By _buttonSubscribe = By.ClassName("body > div.site-wrap > footer > div > form > div.footer-input-row > button");
        By _popupEmailSubscribeConfirmed = By.ClassName("#popup__window > div.popup-content > p");
        string confirmedText = "Вы успешно подписались на эту рассылку!";
        By _linkFb = By.ClassName("fb");
        By _linkYt = By.ClassName("yt");
        By _linkTw = By.ClassName("tw");
        By _linkIg = By.ClassName("ig");

        By _linkDelivery = By.CssSelector("body > div.site-wrap > footer > div > div.footer-columns > div.footer-nav-wrap > div > div:nth-child(1) > h3 > a");
        By _linkPayment = By.CssSelector("body > div.site-wrap > footer > div > div.footer-columns > div.footer-nav-wrap > div > div:nth-child(1) > ul > li:nth-child(1) > a");
        By _linkabout = By.CssSelector("body > div.site-wrap > footer > div > div.footer-columns > div.footer-nav-wrap > div > div:nth-child(1) > ul > li:nth-child(2) > a");


        // By search
        By _searchField = By.Id("search-input");
        By _searchButton = By.CssSelector("body > div.site-wrap > div.main-wrap > header > div.header-middle > div > div.header-right > div:nth-child(2) > form > button.search-button");

        public bool elementHasClass(IWebElement element, string active)
        {

            return element.GetAttribute("class").Contains(active);
        }

        public int GetNumOfActiveSliderItem()
        {
            List<IWebElement> SliderItems = new List<IWebElement> {
                                                                    _driver.FindElement(_sliderItem1),
                                                                    _driver.FindElement(_sliderItem2),
                                                                    _driver.FindElement(_sliderItem3),
                                                                    _driver.FindElement(_sliderItem4),
                                                                    _driver.FindElement(_sliderItem5),
                                                                    _driver.FindElement(_sliderItem6)
                                                                   };
            int count = 0;
            foreach (var item in SliderItems)
            {
                if (elementHasClass(item, "active"))
                {
                    return count;
                }
                count++;
            }
            return 0;
        }

        public string returnConfirmedText()
        {
            return confirmedText;
        }


        public void clickSliderNext()
        {
            Actions action = new Actions(_driver);
            IWebElement slider = _driver.FindElement(By.Id("slider"));
            action.MoveToElement(slider).MoveToElement(_driver.FindElement(_sliderNext)).Click().Build().Perform();

        }
        public void clickSliderPrev()
        {
            Actions action = new Actions(_driver);
            IWebElement slider = _driver.FindElement(By.Id("slider"));
            action.MoveToElement(slider).MoveToElement(_driver.FindElement(_sliderPrev)).Click().Build().Perform();

        }
        public void goToPage()
        {
            _driver.Navigate().GoToUrl(test_url);
        }
        public MainPagePOM clickPrafums()
        {
            _driver.FindElement(_menuItem_Parfums).Click();
            return this;
        }
        public String getPageTitle()
        {
            return _driver.Title;
        }

        public void SearchProduct(string nameProduct)
        {
            _driver.FindElement(_searchField).SendKeys(nameProduct);
            _driver.FindElement(_searchButton).Click();
        }

        public void CheckLinkFooter(string namelink)
        {
            switch (namelink)
            {
                case "delivery":
                    _driver.FindElement(_linkDelivery).Click();
                    break;
                case "payment":
                    _driver.FindElement(_linkPayment).Click();
                    break;
                case "aboutProduct":
                    _driver.FindElement(_linkabout).Click();
                    break;
            }
        }
    }
}
