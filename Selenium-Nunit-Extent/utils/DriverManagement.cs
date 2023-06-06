using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
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
                    driver.Value = new FirefoxDriver();
                    break;
                case "chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(), "113.0.5672.63");
                    driver.Value = new ChromeDriver();
                    break;
                default:
                    throw new Exception("Invalid browser name: " + browserName);
            }

            return driver.Value;
        }

        public static IWebDriver GetDriver => driver.Value;
    }
}
