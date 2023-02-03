using CSharpSelFramework.pageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using selenium_nunit_extent.pageObjects;
using selenium_nunit_extent.utils;
using Selenium_Nunit_Extent.utils;

namespace selenium_nunit_extent.tests
{
    [TestFixture]
    public class CheckBoxTests : BaseTest
    {
        private HomePage homePage = new HomePage();
        private CheckBoxPage checkBoxPage = new CheckBoxPage();

        [Test]
        public void TestCheckCheckBoxes()
        {
            homePage.CheckBoxesPageLink.Click();
            extentTest.Info("Checkboxes page is loaded successfully");

            checkBoxPage.CheckBox1.Click();

            string labelText = checkBoxPage.CheckBox1.FindElement(By.XPath("..")).Text;
            Assert.IsTrue(checkBoxPage.CheckBox1.Selected, "The first checkbox is not checked.");
            extentTest.Info("The first checkbox is checked successfully");
        }

        [Test]
        public void TestUncheckCheckBoxes()
        {
            homePage.CheckBoxesPageLink.Click();
            extentTest.Info("Checkboxes page is loaded successfully");

            checkBoxPage.CheckBox2.Click();

            string labelText = checkBoxPage.CheckBox2.FindElement(By.XPath("..")).Text;
            Assert.IsFalse(checkBoxPage.CheckBox2.Selected, "The second checkbox is checked.");
            extentTest.Info("The second checkbox is unchecked successfully");
        }
    }
}

