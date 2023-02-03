//using System.IO;
//using System.Reflection.PortableExecutable;
//using AventStack.ExtentReports;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;
//using selenium_nunit_extent.utils;
//using Selenium_Nunit_Extent.utils;
//using WebDriverManager.DriverConfigs.Impl;

//namespace selenium_nunit_extent.tests;

//[Parallelizable(ParallelScope.Self)]
//// [Parallelizable(ParallelScope.Children)] // To run all the test methods in this class in parallel

//public class SeleniumTests : BaseTest
//{
//    WebDriverWait? wait;

//    //LandingPage landingPage = new LandingPage(getDriver());


//    [Test, Category("regression")]
//    //[TestCase("run1")]
//    //[TestCase("run2")]
//    //  [Parallelizable(ParallelScope.All)] // To run all the test sets within this test method in parallel
//    public void checkBoxTest()
//    {

//        extentTest.Info("Landing page is loaded sucessfully");

//        TestContext.Progress.WriteLine(DriverManagement.GetDriver.Title);
//        extentTest.Info(DriverManagement.GetDriver.Url);
//        //extentTest.Info("Test run with " + testRun);
//    }

//    //[Test, TestCaseSource(nameof(AddTestDataConfig)), Category("smoke")]
//    //public void Test2(String testcaseRun)
//    //{

//    //}

//    //public static IEnumerable<TestCaseData> AddTestDataConfig()
//    //{
//    //    yield return new TestCaseData("run 1");
//    //    yield return new TestCaseData("run 2");
//    //}

//}
