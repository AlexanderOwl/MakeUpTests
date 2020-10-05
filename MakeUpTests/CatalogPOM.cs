using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpTests
{
   public class CatalogPOM
    {
        IWebDriver driver;

        public CatalogPOM (IWebDriver driver)
        {
            this.driver = driver;
        }

        By _pageheader = By.CssSelector("body > div.site-wrap > div.main-wrap > div > div > div:nth-child(2) > h1");
        By _breadcrumbs = By.CssSelector("body > div.site-wrap > div.main-wrap > div > div > div:nth-child(2) > h1");
        By _productItemDescription = By.CssSelector("body > div.site-wrap > div.main-wrap > div > div > div:nth-child(2) > div.catalog > div.catalog-content > div > div.catalog-products > ul > li:nth-child(1) > div.simple-slider-list__link > div.info-product-wrapper > div.simple-slider-list__description");

        public bool HasTextPageHeader(string nameProduct)
        {
          string text=driver.FindElement(_pageheader).Text;        
          return text.Contains(nameProduct);
        }

        public bool HasProduct(string nameProduct)
        {
            string text = driver.FindElement(_productItemDescription).Text;
            return text.Contains(nameProduct);
        }

    }
}
