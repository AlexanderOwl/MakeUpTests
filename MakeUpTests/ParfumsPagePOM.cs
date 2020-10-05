using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpTests
{
    class ParfumsPagePOM
    {
        IWebDriver _driver;
        public ParfumsPagePOM(IWebDriver driver)
        {
            this._driver = driver;
            
        }
        string test_url = "https://makeup.com.ua/categorys/3/";
        By _sortItemPrice = By.CssSelector("#sort-form > ul > li:nth-child(2) > label");
        By _sortItemAscending = By.CssSelector("#sort-form > ul > li:nth-child(5) > label");
        By _firstItemPrice = By.CssSelector("body > div.site-wrap > div.main-wrap > div > div > div:nth-child(2) > div.catalog > div.catalog-content > div > div.catalog-products > ul > li:nth-child(1) > div.simple-slider-list__link > div.info-product-wrapper > div.simple-slider-list__price_container > span > span");
        By _lastItemOnPagePrice = By.CssSelector("body > div.site-wrap > div.main-wrap > div > div > div:nth-child(2) > div.catalog > div.catalog-content > div > div.catalog-products > ul > li:nth-child(36) > div.simple-slider-list__link > div.info-product-wrapper > div.simple-slider-list__price_container > span > span");

        
        public string headerText = "Парфюмерия — купить оригинальные духи с бесплатной доставкой по Украине | Makeup.ua";
        public void goToPage()
        {
            _driver.Navigate().GoToUrl(test_url);
        }
        public void clickSortItemPrice()
        {          
            _driver.FindElement(_sortItemPrice).Click();  
        }
        public void clickSortItemAscending()
        {
            _driver.FindElement(_sortItemAscending).Click();
        }

        public double returnFirstItemPrice()
        {           
            double firstItemPtice = double.Parse(_driver.FindElement(_firstItemPrice).Text);            
            return firstItemPtice;
        }
        public double returnLastItemPrice()
        {            
            double lastPrice = double.Parse(_driver.FindElement(_lastItemOnPagePrice).Text);           
            return lastPrice;
        }

    }
}
