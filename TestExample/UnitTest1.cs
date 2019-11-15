using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Assert = NUnit.Framework.Assert;
using DescriptionAttribute = NUnit.Framework.DescriptionAttribute;

namespace TestExample
{
    [TestFixture]
    public class UnitTest1
    {
        ChromeDriver driver;
        String acresult;
        String exresult = "Identifiants Non Valides";
        String title = "OrangeHRM";

        [SetUp]
        public void TestStart()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

        [Test]
        [Description ("Verify if application accepts invalid username and password details")]
        [Author ("Tejesh Shirodkar")]
        public void TC01()
        {
            Details obj = new Details();
            obj.InvalidUser1();
            var uname = obj.username;
            var pwd = obj.password;
            driver.FindElementById("txtUsername").Clear();
            driver.FindElementById("txtUsername").SendKeys(uname);
            driver.FindElementById("txtUsername").Clear();
            driver.FindElementById("txtPassword").SendKeys(pwd);
            driver.FindElementById("btnLogin").Click();
            acresult = driver.FindElementById("spanMessage").Text;
            Assert.AreEqual(acresult,exresult);
            
        }

        [Test]
        [Description("Verify if application accepts invalid username and valid password details")]
        [Author("Tejesh Shirodkar")]
        public void TC02()
        {
            Details obj = new Details();
            obj.InvalidUser2();
            var uname = obj.username;
            var pwd = obj.password;
            driver.FindElementById("txtUsername").Clear();
            driver.FindElementById("txtUsername").SendKeys(uname);
            driver.FindElementById("txtUsername").Clear();
            driver.FindElementById("txtPassword").SendKeys(pwd);
            driver.FindElementById("btnLogin").Click();
            acresult = driver.FindElementById("spanMessage").Text;
            Assert.AreEqual(acresult, exresult);
        }
        [Test]
        [Description("Verify if application accepts valid username and invalid password details")]
        [Author("Tejesh Shirodkar")]
        public void TC03()
        {
            Details obj = new Details();
            obj.InvalidUser3();
            var uname = obj.username;
            var pwd = obj.password;
            driver.FindElementById("txtUsername").Clear();
            driver.FindElementById("txtUsername").SendKeys(uname);
            driver.FindElementById("txtUsername").Clear();
            driver.FindElementById("txtPassword").SendKeys(pwd);
            driver.FindElementById("btnLogin").Click();
            acresult = driver.FindElementById("spanMessage").Text;
            Assert.AreEqual(acresult, exresult);
        }

        [Test]
        [Description("Verify if application accepts valid username and password details")]
        [Author("Tejesh Shirodkar")]
        public void TC04()
        {
            Details obj = new Details();
            obj.ValidUser();
            var uname = obj.username;
            var pwd = obj.password;
            driver.FindElementById("txtUsername").Clear();
            driver.FindElementById("txtUsername").SendKeys(uname);
            driver.FindElementById("txtUsername").Clear();
            driver.FindElementById("txtPassword").SendKeys(pwd);
            driver.FindElementById("btnLogin").Click();
            Assert.AreEqual(driver.Title, title);
        }

        [TearDown]
        public void TestEnd()
        {
            driver.Close();
            driver.Dispose();
        }        
    
    }
}
