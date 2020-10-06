using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpTests
{
  public  class HeaderLinksPOM
    {
        IWebDriver driver;

        By _linkPromoutions = By.CssSelector("body > div.site-wrap > div.main-wrap > header > div.header-top > div > div:nth-child(2) > ul > li.header-top-list__item.promoted > a");
        By _linkBeatyClub = By.XPath("/html/body/div[1]/div[1]/header/div[1]/div/div[2]/ul/li[2]/a");
        By _linkDelivery = By.CssSelector("body > div.site-wrap > div.main-wrap > header > div.header-top > div > div:nth-child(2) > ul > li:nth-child(3) > a");
        By _linkArticle = By.CssSelector("body > div.site-wrap > div.main-wrap > header > div.header-top > div > div:nth-child(2) > ul > li:nth-child(4) > a");
        By _linkAboutShop = By.CssSelector("body > div.site-wrap > div.main-wrap > header > div.header-top > div > div:nth-child(2) > ul > li:nth-child(5) > a");

        public HeaderLinksPOM(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CheckLinkHeader(string namelink)
        {
            switch (namelink)
            {
                case "promotion":
                    driver.FindElement(_linkPromoutions).Click();
                    break;
                case "beatyClub":
                    driver.FindElement(_linkBeatyClub).Click();
                    break;
                case "delivery":
                    driver.FindElement(_linkDelivery).Click();
                    break;
                case "article":
                    driver.FindElement(_linkArticle).Click();
                    break;
                case "aboutShop":
                    driver.FindElement(_linkAboutShop).Click();
                    break;
            }
        }
    }
}
