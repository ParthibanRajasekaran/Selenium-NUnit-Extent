using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using selenium_nunit_extent.pageObjects;
using selenium_nunit_extent.utils;
using Selenium_Nunit_Extent.utils;

namespace CSharpSelFramework.pageObjects
{
    public class HomePage
    {
        private By _pageHeader = By.CssSelector("div#content h2");
        private By _checkBoxesPageLink = By.CssSelector("a[href='/checkboxes']");
        private By _inputPageLink = By.CssSelector("a[href='/inputs']");
        private By _framesPageLink = By.CssSelector("a[href='/frames']");


        public IWebElement PageHeader => DriverManagement.GetDriver.FindElement(_pageHeader);

        public IWebElement CheckBoxesPageLink => DriverManagement.GetDriver.FindElement(_checkBoxesPageLink);

        public IWebElement InputPageLink => DriverManagement.GetDriver.FindElement(_inputPageLink);

        public IWebElement FramesPageLink => DriverManagement.GetDriver.FindElement(_framesPageLink);
    }
}