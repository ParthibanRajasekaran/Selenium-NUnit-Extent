using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;

namespace Selenium_Nunit_Extent.utils
{
	public class Reporter
	{
	
        public ExtentReports extentReports;
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

        public MediaEntityModelProvider CaptureScreenshot(IWebDriver driver, string screenshotName)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
            var mediaEntity = MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenshotName).Build();
            return mediaEntity;
        }
    }
}

