using AventStack.ExtentReports;
using CSharpSelFramework.pageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using selenium_nunit_extent.pageObjects;
using selenium_nunit_extent.utils;
using Selenium_Nunit_Extent.utils;

namespace selenium_nunit_extent.tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Children)]
    public class CheckBoxTests : BaseTest
    {
        private HomePage homePage = new HomePage();
        private CheckBoxPage checkBoxPage = new CheckBoxPage();

        [Test]
        public void TestCheckCheckBoxes()
        {
            homePage.CheckBoxesPageLink.Click();
            extentTest.Log(Status.Info, "Checkboxes page is loaded successfully");
            checkBoxPage.CheckBox1.Click();
            extentTest.Log(Status.Info, "Checkbox 1 is checked on successfully");

            string labelText = checkBoxPage.CheckBox1.FindElement(By.XPath("..")).Text;
            extentTest.Log(Status.Info, "Label text on the first checkbox is: " + labelText);
            Assert.IsTrue(checkBoxPage.CheckBox1.Selected, "The first checkbox is not checked.");
            extentTest.Log(Status.Info, "The first checkbox is checked successfully");
        }

        [Test]
        public void TestUncheckCheckBoxes()
        {
            homePage.CheckBoxesPageLink.Click();
            extentTest.Log(Status.Info, "Checkboxes page is loaded successfully");

            checkBoxPage.CheckBox2.Click();
            extentTest.Log(Status.Info, "Checkbox 2 is unchecked successfully");

            string labelText = checkBoxPage.CheckBox2.FindElement(By.XPath("..")).Text;
            extentTest.Log(Status.Info, "Label text on the second checkbox is: " + labelText);
            Assert.IsFalse(checkBoxPage.CheckBox2.Selected, "The second checkbox is checked.");
            extentTest.Log(Status.Info, "The second checkbox is unchecked successfully");
        }
    }
}

