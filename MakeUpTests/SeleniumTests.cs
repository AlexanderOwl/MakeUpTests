using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MakeUpTests
{
    public class SeleniumTests
    {
        public static Func<IWebDriver, bool> UrlToBe(string url)
        {
            return (driver) => { return driver.Url.ToLowerInvariant().Equals(url.ToLowerInvariant()); };
        }
        public string GenRandomString()
        {
            string Alphabet = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            Random randomlen = new Random();
            int Length = randomlen.Next(5,12);
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(Length - 1);
            int Position;

            for (int i = 0; i < Length; i++)
            {
                Position = rnd.Next(0, Alphabet.Length - 1);
                sb.Append(Alphabet[Position]);                
            }
            sb.Append("@gmail.com");
            return sb.ToString();
        }

        static IWebDriver driver; 
       

        [TestFixture]
        public class MainPageTests
        {
            MainPagePOM mainPage;
            ParfumsPagePOM parfumPage;
            ProductPagePOM productPage;
            [SetUp]
            public void openMainPage()
            {
                driver = new ChromeDriver(@"D:\Proga\Курсы\MakeUpTests\packages\Selenium.WebDriver.ChromeDriver.85.0.4183.8700\driver\win32");
                mainPage = new MainPagePOM(driver);
                parfumPage = new ParfumsPagePOM(driver);
                productPage = new ProductPagePOM(driver);
                mainPage.goToPage();
                driver.Manage().Window.Maximize();
            }
            
            [TearDown]
            public void quit()
            {
                driver.Quit();
            }
            [TestCase(0)]
            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]
            [TestCase(5)]
            public void CLickSliderRigth(int count)
            {               
                for (int i = 0; i < count; i++)
                {
                    mainPage.clickSliderNext();
                }
                Assert.AreEqual(count, mainPage.GetNumOfActiveSliderItem());
            }

            //[TestCase(0)]
            //[TestCase(1)]
            //[TestCase(2)]
            //[TestCase(3)]
            //[TestCase(4)]
            //[TestCase(5)]
            //public void WaitSliderRigth(int num)
            //{                
            //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //    Assert.AreEqual(num, mainPage.GetNumOfActiveSliderItem());
            //}

            [TestCase(1,5)]
            [TestCase(2,4)]
            [TestCase(3,3)]
            [TestCase(4,2)]
            [TestCase(5,1)]
            public void CLickSliderLeft(int click, int num)
            {
                for (int i = 0; i < click; i++)
                {
                    mainPage.clickSliderPrev();
                }
                Assert.AreEqual(num, mainPage.GetNumOfActiveSliderItem());
            }

            [Test]
            public void CheckNavigateParfumsPage()
            {
                mainPage.clickPrafums();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Assert.AreEqual(parfumPage.headerText, driver.Title);
            }

            [Test] //nf
            public void SortPriceAsc()
            {
                parfumPage.goToPage();               
                parfumPage.clickSortItemPrice();                
                parfumPage.clickSortItemAscending();
                new WebDriverWait(driver, driver.Manage().Timeouts().PageLoad);
                Assert.Greater(parfumPage.returnLastItemPrice(), parfumPage.returnFirstItemPrice());
            }

            [Test] 
            public void CheckIncreaseTotalPrice()
            {
                productPage.goToPage();
                double price = productPage.returnPrice();
                productPage.clickButtonBuy();
                IWebElement waitButton = (new WebDriverWait(driver, TimeSpan.FromSeconds(20))).Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("body > div.popup.cart.ng-animate.ng-hide-animate > div > div.popup-content > div.product-list-wrap > ul > li > div > div.product__count-list > div.product__button-increase")));
                productPage.clickButtonIncrease();
                bool waitLoad = (new WebDriverWait(driver, TimeSpan.FromSeconds(20))).Until(ExpectedConditions.StalenessOf(driver.FindElement(By.CssSelector("body > div.popup.cart.ng-animate.ng-hide-animate > div > div.popup-content > div.product-list-wrap > ul > li > div > div.product__count-list > div.product__button-increase"))));
                Assert.Greater(productPage.returnTotalPrice(), price);
            }
        }
    }
}
