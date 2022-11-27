using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class DangNhap
    {
        [TestMethod]
        public void DN_01()
        {
            //"Test chức năng đăng nhập bỏ trống User Name và Password"

            int waitingTime = 1000;          

            By loginButton = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input");           

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("http://thanhluyen221200-001-site1.gtempurl.com/Login");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.CssSelector(".field-validation-error")).Text.Equals("The UserName field is required."));
           
            Thread.Sleep(waitingTime);
        }

        [TestMethod]
        public void DN_02()
        {
            //""Test chức năng đăng nhập bỏ trống User Name và nhập đúng Password"

            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("http://thanhluyen221200-001-site1.gtempurl.com/Login");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("Password")).SendKeys("123ddd456789");
            Thread.Sleep(waitingTime);

            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.CssSelector(".field-validation-error")).Text.Equals("The UserName field is required."));
            
            Thread.Sleep(waitingTime);
        }

        [TestMethod]
        public void DN_03()
        {
            //""Test chức năng đăng nhập nhập User Name và bỏ trống Password"

            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("http://thanhluyen221200-001-site1.gtempurl.com/Login");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("UserName")).SendKeys("tr");
            Thread.Sleep(waitingTime);

            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.CssSelector(".field-validation-error")).Text.Equals("The Password field is required."));

            Thread.Sleep(waitingTime);
        }

        [TestMethod]
        public void DN_04()
        {
            //"Test chức năng đăng nhập nhập sai User Name và nhập sai Password

            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("http://thanhluyen221200-001-site1.gtempurl.com/Login");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("UserName")).SendKeys("tr");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123ddd456789");
            Thread.Sleep(waitingTime);

            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.CssSelector(".text-danger")).Text.Equals("Sai thông tin tài khoản"));

            Thread.Sleep(waitingTime);
        }


        [TestMethod]
        public void DN_05()
        {
            //""Test chức năng đăng nhập nhập sai User Name và nhập đúng Password

            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("http://thanhluyen221200-001-site1.gtempurl.com/Login");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("UserName")).SendKeys("tuan");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123ddd456789");
            Thread.Sleep(waitingTime);

            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.CssSelector(".text-danger")).Text.Equals("Sai thông tin tài khoản"));

            Thread.Sleep(waitingTime);
        }


        [TestMethod]
        public void DN_06()
        {
            //"Test chức năng đăng nhập nhập đúng User Name và sai Password

            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("http://thanhluyen221200-001-site1.gtempurl.com/Login");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("UserName")).SendKeys("tuan");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123ddd456789");
            Thread.Sleep(waitingTime);

            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.CssSelector(".text-danger")).Text.Equals("Sai thông tin tài khoản"));

            Thread.Sleep(waitingTime);
        }


        [TestMethod]
        public void DN_07()
        {
            //"Test chức năng đăng nhập nhập đúng User Name và sai Password

            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("http://thanhluyen221200-001-site1.gtempurl.com/Login");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("UserName")).SendKeys("tuan");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123");
            Thread.Sleep(waitingTime);

            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);

            string URL = webDriver.Url;
            
            Assert.AreEqual(URL, "http://thanhluyen221200-001-site1.gtempurl.com/");
        }


    }

}
