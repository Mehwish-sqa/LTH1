using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using LTH;
using ExcelLTH;
using OpenQA.Selenium.Support.UI;

namespace LighthouseApp
{
    [TestClass]
    public class Lighthouse
    {
        static ExtentHtmlReporter htmlreporter = new ExtentHtmlReporter(@"C:\SS\ExtentReport\ExtentReport.html");
        static ExtentReports extent = new ExtentReports();
        IWebDriver LH;
        IWebElement element;

        [TestInitialize]
        public void SetUp()
        {
            extent.AttachReporter(htmlreporter);
        }

        [TestMethod]
        public void EnvVariables()
        {
            extent.AddSystemInfo("<div style='color:green; font -weight : bold'>Operating System</div>", "<div style = 'color:red; font -weight : bold'> Win 10 </div>");
            extent.AddSystemInfo("<div style='color:green; font -weight : bold'>HostName</div>", "<div style='color:red; font -weight : bold'>Mehwish Younus</div>");
            extent.AddSystemInfo("<div style='color:green; font -weight : bold'>Browser</div>", "<div style='color:red; font -weight : bold'>Google Chrome</div>");
            extent.AddSystemInfo("<div style='color:green; font -weight : bold'>Environment</div>", "<div style='color:red; font -weight : bold'>QA</div>");
            extent.AddSystemInfo("<div style='color:green; font -weight : bold'>Product Environment</div>", "<div style='color:red; font -weight : bold'>UAT</div>");
            extent.AddSystemInfo("<div style='color:green; font -weight : bold'>Product URL</div>", "<div style='color:red; font -weight : bold'>https://uat.prismpay.com</div>");
            System.Threading.Thread.Sleep(2000);
        }
        [TestMethod]
        [Description("Login/Logoff")]
        public void LHLogin()
        {
            // var test = extent.CreateTest("<div style='color:green; font -weight : bold'>Create Admin</div>", "This case may attains passed or failed");
            try
            {

                string paths = @"C:\ExcelReports\LoginLogout.xlsx";
                ExcelLogin.PopulateInCollection(paths);

                LH = new ChromeDriver();
                LH.Manage().Window.Maximize();
                LH.Manage().Cookies.DeleteAllCookies();
                LH.Navigate().GoToUrl("https://app-latest-us4.usdev.wfsaas.net/#/login");

                // Assert.AreEqual("latest", LH.Title);


                WebDriverWait wait = new WebDriverWait(LH, TimeSpan.FromSeconds(15));
                // test.Log(Status.Info, "Steps are Processing");
                // test.Log(Status.Info, "Create Admin steps are processing");

                LoginLogout login = new LoginLogout(LH);
                //PageFactory.InitElements(Atlas, login);
                login.AccountId1();
                login.CliNext1();
                login.UserName1();
                login.Password1();
                login.assetforgot();



                login.submit1();
                login.usernav1();
                login.logout1();

                // System.Threading.Thread.Sleep(20000);
                //// string screenshot = Util.Capture(Atlas, "Create Admin");
                //test.Pass("Create Admin been completed");
                //test.Pass("Create Admin been Done");
                //// test.AddScreenCaptureFromPath(screenshot);

            }
            catch (Exception e)
            {
                //test.Log(Status.Fail, "So SAD");
                // string screenshots3 = Util.Capture(Atlas, "Failed Admin");
                //test.Fail("Admin Case been failed :(");

                //  test.AddScreenCaptureFromPath(screenshots3);

                Console.WriteLine(e.Message);
            }
            finally
            {
                extent.Flush();
            }
        }
        [TestMethod]
        [Description("Login/Logoff")]
        public void LTHUITest()
        {
            // var test = extent.CreateTest("<div style='color:green; font -weight : bold'>Create Admin</div>", "This case may attains passed or failed");
            try
            {

                string paths = @"C:\ExcelReports\LoginLogout.xlsx";
                ExcelLogin.PopulateInCollection(paths);

                LH = new ChromeDriver();
                LH.Manage().Window.Maximize();
                LH.Manage().Cookies.DeleteAllCookies();
                LH.Navigate().GoToUrl("https://app-latest-us4.usdev.wfsaas.net/#/login");

                // Assert.AreEqual("latest", LH.Title);


                WebDriverWait wait = new WebDriverWait(LH, TimeSpan.FromSeconds(15));
                // test.Log(Status.Info, "Steps are Processing");
                // test.Log(Status.Info, "Create Admin steps are processing");

                LHUITest UI = new LHUITest(LH);
                //PageFactory.InitElements(Atlas, login);
                UI.AccountId1();
                UI.CliNext1();
                UI.UserName1();
                UI.Password1();
                UI.assetforgot();
                UI.content1();
                UI.logo1();
                UI.accountname1();
                UI.acclogobtn1();



                UI.submit1();
                UI.usernav1();
                UI.logout1();

                // System.Threading.Thread.Sleep(20000);
                //// string screenshot = Util.Capture(Atlas, "Create Admin");
                //test.Pass("Create Admin been compaleted");
                //test.Pass("Create Admin been Done");
                //// test.AddScreenCaptureFromPath(screenshot);

            }
            catch (Exception e)
            {
                //test.Log(Status.Fail, "So SAD");
                // string screenshots3 = Util.Capture(Atlas, "Failed Admin");
                //test.Fail("Admin Case been failed :(");

                //  test.AddScreenCaptureFromPath(screenshots3);

                Console.WriteLine(e.Message);
            }
            finally
            {
                extent.Flush();
            }
        }
    }
}
