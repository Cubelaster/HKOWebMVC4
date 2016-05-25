using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions.Internal;
using SeleniumTests;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTests
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            /* Start the driver without any parameter and it will throw and error, showing you from where
             * you can download the driver. */
            //var driver = new InternetExplorerDriver(@"F:\Dokumenti\Edukacija\Selenium Testing\Drivers\");
            driver.Url = "http://www.google.com";

            var searchbox = driver.FindElement(By.Id("lst-ib"), 2);
            searchbox.SendKeys("pluralsite");

            var imageLink = driver.FindElements(By.ClassName("q"), 2)[0];
            imageLink.Click();
        }
    }
}