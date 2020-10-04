using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpTests
{
    class MainPagePOM
    {
        By menuItem_Parfums = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(1)");
        By menuItem_MakeUp = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(2)");
        By menuItem_Nails = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(3)");
        By menuItem_Hair = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(4)");
        By menuItem_Face = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(5)");
        By menuItem_BodyAndBath = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(6)");
        By menuItem_Mens = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(7)");
        By menuItem_Acssesories = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(8)");
        By menuItem_HealthAndCare = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(9)");
        By menuItem_Gift = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(10)");
        By menuItem_Brands = By.CssSelector("body > div.site-wrap > div.main-wrap > nav > div.layout > ul > li:nth-child(11)");
        By inputSearch = By.Id("search-input");
        By headerBasket = By.ClassName("header-basket");
        By buttonCallBack = By.CssSelector("body > div.site-wrap > div.main-wrap > header > div.header-middle > div > div.header-contact > div.button");
        By sliderNext = By.ClassName("slider-arrow-next");
        By sliderPrev = By.ClassName("slider-arrow-prev");
        By sliderItem1 = By.CssSelector("#slider > ul.slides > li:nth-child(2)");
        By sliderItem2 = By.CssSelector("#slider > ul.slides > li:nth-child(3)");
        By sliderItem3 = By.CssSelector("#slider > ul.slides > li:nth-child(4)");
        By sliderItem4 = By.CssSelector("#slider > ul.slides > li:nth-child(5)");
        By sliderItem5 = By.CssSelector("#slider > ul.slides > li:nth-child(6)");
        By sliderItem6 = By.CssSelector("#slider > ul.slides > li:nth-child(7)");
        By inputEmail = By.CssSelector("body > div.site-wrap > footer > div > form > div.footer-input-row > div > input");
        By buttonSubscribe = By.ClassName("body > div.site-wrap > footer > div > form > div.footer-input-row > button");
        By popupEmailSubscribeConfirmed = By.ClassName("#popup__window > div.popup-content > p");
        string confirmedText = "Вы успешно подписались на эту рассылку!";
        By linkFb = By.ClassName("fb");
        By linkYt = By.ClassName("yt");
        By linkTw = By.ClassName("tw");
        By linkIg = By.ClassName("ig");

        private IWebDriver driver;

        public bool elementHasClass(IWebElement element, String active)
        {
            return element.GetAttribute("class").Contains(active);
        }

        public MainPagePOM click()
        {
            return this;
        }


    }
}
