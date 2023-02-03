using System.Configuration;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using CSharpSelFramework.pageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using selenium_nunit_extent.pageObjects;
using Selenium_Nunit_Extent.utils;
using WebDriverManager.DriverConfigs.Impl;

namespace selenium_nunit_extent.utils
{
	public class BaseTest
	{


        ExtentReports extentReports;
        public ExtentTest extentTest;

        [OneTimeSetUp]
        public void SetupReporting()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            String reportPath = projectDirectory + "//index.html";
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            extentReports = new ExtentReports();
            extentReports.AttachReporter(htmlReporter);
            extentReports.AddSystemInfo("Author", "Parthiban Rajasekaran");
        }

        [SetUp]
        public void SetupBrowser()
        {
            // Create an entry for the extent listener
            extentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.Name);

            string browser = TestContext.Parameters["browserName"] ?? ConfigurationManager.AppSettings["browserName"] ?? "chrome";
            TestContext.Progress.WriteLine("Test are running on browser: "+ browser);
            DriverManagement.SetDriver(browser);
            extentTest.Log(Status.Info,"Browser is configured");

            DriverManagement.GetDriver.Url = "https://the-internet.herokuapp.com/";
        }

        [TearDown]
        public void CloseBrowser()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var failureMessage = TestContext.CurrentContext.Result.StackTrace;

            DateTime dateTime = DateTime.Now;
            String imageName = "Screenshot_" + TestContext.CurrentContext.Test.Name + "_" + dateTime.ToString("h_mm_ss") + ".png";

            if(testStatus == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                extentTest.Fail("Test Failed", CaptureScreenshot(DriverManagement.GetDriver, imageName));
                extentTest.Log(Status.Fail,"Test Failed: "+ failureMessage);
            } else if(testStatus == NUnit.Framework.Interfaces.TestStatus.Passed)
            {

            }
            extentReports.Flush();
            DriverManagement.GetDriver.Quit();
            extentTest.Log(Status.Info, "Browser is closed");
            
        }


        public MediaEntityModelProvider CaptureScreenshot(IWebDriver driver, string screenshotName)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
            var mediaEntity = MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenshotName).Build();
            return mediaEntity;
        }


        public JsonReader getTestData()
        {
            return new JsonReader();
        }
    }
}
