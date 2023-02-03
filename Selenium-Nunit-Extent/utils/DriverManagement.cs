using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium_Nunit_Extent.utils
{
    public class DriverManagement
    {
        private static readonly ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static IWebDriver SetDriver(string browserName)
        {
            switch (browserName)
            {
                case "firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    return driver.Value = new FirefoxDriver();
                case "chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    return driver.Value = new ChromeDriver();
                default:
                    throw new Exception("Invalid browser name: " + browserName);
            }
        }

        public static IWebDriver GetDriver => driver.Value;
    }
}

