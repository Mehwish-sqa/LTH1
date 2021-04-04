using ExcelLTH;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace LTH
{
    public class LHUITest
    {
        IWebDriver LH;
        By AccountId = By.XPath("//INPUT[@id='OrganizationIdTextField']");
        By CliNext = By.XPath("//SPAN[@class='button__text'][text()='Next']");
        By UserName = By.XPath("//INPUT[@id='username']");
        By Password = By.XPath("//INPUT[@id='password']");
        By ForgeotPass = By.XPath("//A[@tabindex='5'][text()='Forgot password']");
        By content = By.XPath("//H5[@class='workforce-login-text'][text()='WorkForce Suite Login']");
        By Logo = By.XPath("//IMG[@src='/auth/resources/wgrma/login/lighthouse/img/workforce-logo.png']");
        By AccountName = By.XPath("//P[@id='kc-header-wrapper']");
        By AccEditBtn = By.XPath("//I[@onclick='redirectToAccountPage();']");
        By submit = By.XPath("//INPUT[@id='submitButton']");
        By usernav = By.XPath("//DIV[@class='MuiAvatar-root MuiAvatar-circle sc-kAzzGY sc-chPdSV dRJSKd menu-avatar MuiAvatar-colorDefault'][text()='TN']");
        By logout = By.XPath("//li[@id='logoutSign Out']");

        public LHUITest(IWebDriver LH)
        {
            this.LH = LH;
        }
        public void AccountId1()
        {
            LH.FindElement(AccountId).SendKeys(ExcelLogin.ReadData(1, "AccountID"));

        }
        public void CliNext1()
        {
            LH.FindElement(CliNext).Click();
            System.Threading.Thread.Sleep(5000);
        }
        public void UserName1()
        {

            LH.FindElement(UserName).SendKeys(ExcelLogin.ReadData(1, "UserName"));
        }
        public void Password1()
        {
            LH.FindElement(Password).SendKeys(ExcelLogin.ReadData(1, "Password"));
            System.Threading.Thread.Sleep(4000);
        }
        public void assetforgot()
        {
            Assert.IsTrue(LH.FindElement(ForgeotPass).Displayed);
            Console.WriteLine("Forgot Password button - Assetion Passed");
        }

        public void content1()
        {

            string page_ele = "WorkForce Suite Login";
            Assert.IsTrue(LH.FindElement(content).Text.Contains(page_ele));
            Console.WriteLine("Suite Element Present on Page - Assertion Passed");
            System.Threading.Thread.Sleep(2000);
        }
        public void logo1()
        {
            Assert.IsTrue(LH.FindElement(Logo).Displayed);
            Console.WriteLine("Logo is Present - Assertion Passed");
            System.Threading.Thread.Sleep(2000);

        }
        public void accountname1()
        {
            Assert.IsTrue(LH.FindElement(AccountName).Displayed);
            Console.WriteLine("Account Name is Present - Assetion Passed");
        }
        public void acclogobtn1()
        {
            Assert.IsTrue(LH.FindElement(AccEditBtn).Displayed);
            Console.WriteLine("Accounr Edit button is Present - Assertion Passed");
        }
        public void submit1()
        {
            LH.FindElement(submit).Click();
            System.Threading.Thread.Sleep(13000);
            //WebDriverWait b = new WebDriverWait(LH, TimeSpan.FromSeconds(15));
        }
        public void usernav1()
        {
            LH.FindElement(usernav).Click();
            System.Threading.Thread.Sleep(4000);

            // WebDriverWait c = new WebDriverWait(LH, TimeSpan.FromSeconds(4));
        }
        public void logout1()
        {
            LH.FindElement(logout).Click();
        }

    }
}



