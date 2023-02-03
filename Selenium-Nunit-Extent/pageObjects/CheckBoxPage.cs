using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using selenium_nunit_extent.utils;
using Selenium_Nunit_Extent.utils;

namespace selenium_nunit_extent.pageObjects
{
    public class CheckBoxPage
    {

        private readonly By _pageHeader = By.CssSelector("div.example h3");
        private readonly By _checkBox1 = By.CssSelector("form#checkboxes input[type='checkbox']:first-child");
        private readonly By _checkBox2 = By.CssSelector("form#checkboxes input[type='checkbox']:last-child");

        public IWebElement PageHeader => DriverManagement.GetDriver.FindElement(_pageHeader);
        public IWebElement CheckBox1 => DriverManagement.GetDriver.FindElement(_checkBox1);
        public IWebElement CheckBox2 => DriverManagement.GetDriver.FindElement(_checkBox2);
    }
}



