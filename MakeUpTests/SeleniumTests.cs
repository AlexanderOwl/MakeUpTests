using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpTests
{
    public class SeleniumTests
    {
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

        static IWebDriver driver = new ChromeDriver(@"D:\Proga\Курсы\MakeUpTests\packages\Selenium.WebDriver.ChromeDriver.85.0.4183.8700\driver\win32");
        MainPagePOM mainPage = new MainPagePOM();

        [TestFixture]
        public class MainPageTests
        {
            [SetUp]
            public void openMainPage()
            {
                driver.Navigate().GoToUrl("https://makeup.com.ua/");
            }
            [TearDown]
            public void quit()
            {
                driver.Quit();
            }
        }
    }
}
