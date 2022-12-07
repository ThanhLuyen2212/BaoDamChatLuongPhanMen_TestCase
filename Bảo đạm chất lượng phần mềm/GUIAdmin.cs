using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class GUIAdmin
    {
        
        IWebDriver webDriver = new ChromeDriver();

        [TestMethod]
        public void GUIAD_01()
        {

            int waitingTime = 1000;

            
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/admin/adminlogin");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            Assert.IsTrue(webDriver.Title.Equals("Đăng nhập"));

            webDriver.Quit();
        }

        [TestMethod]
        public void Login()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/admin/adminlogin");
            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/form/div/div/div/div/div/div/div[4]/input");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            webDriver.FindElement(By.Name("UserName")).SendKeys("123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123");
            Thread.Sleep(waitingTime);

            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);
        }



        [TestMethod]
        public void GUIAD_02()
        {

            int waitingTime = 1000;
            // đăng nhập
            By loginButton = By.XPath("/html/body/form/div/div/div/div/div/div/div[4]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/admin/adminlogin");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("UserName")).SendKeys("123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123");
            Thread.Sleep(waitingTime);

            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);
            // kết thúc đăng nhập
           
            Assert.IsTrue(webDriver.Title.Equals("Trang chủ"));

            webDriver.Quit();
        }

        [TestMethod]
        public void GUIAD_03()
        {
            int waitingTime = 1000;

            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[4]/a/span[2]"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btnDH = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[4]/div/ul/li[1]/a"));
            btnDH.Click();

            Assert.IsTrue(webDriver.Title.Equals("Mặt hàng"));

            webDriver.Quit();
        }

        [TestMethod]
        public void GUIAD_04()
        {

            int waitingTime = 1000;

            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a/span[2]"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btnTMH = webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/a/button"));
            btnTMH.Click();

            Assert.IsTrue(webDriver.Title.Equals("Thêm mặt hàng"));

            webDriver.Quit();
        }

        [TestMethod]
        public void GUIAD_05()
        {

            int waitingTime = 1000;

            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a/span[2]"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btnCNMH = webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr[1]/td[7]/a[2]/button"));
            btnCNMH.Click();

            Assert.IsTrue(webDriver.Title.Equals("Cập nhật mặt hàng"));

            webDriver.Quit();
        }

        [TestMethod]
        public void GUIAD_06()
        {

            int waitingTime = 1000;

            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a/span[2]"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btnCNMH = webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr[1]/td[7]/a[3]/button"));
            btnCNMH.Click();

            Assert.IsTrue(webDriver.Title.Equals("Xóa mặt hàng"));

            webDriver.Quit();
        }

        [TestMethod]
        public void GUIAD_07()
        {

            int waitingTime = 1000;

            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();            

            Assert.IsTrue(webDriver.Title.Equals("Khách hàng"));

            webDriver.Quit();
        }

        [TestMethod]
        public void GUIAD_08()
        {

            int waitingTime = 1000;

            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btnDH = webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/a/button"));
            btnDH.Click();

            Assert.IsTrue(webDriver.Title.Equals("Thêm khách hàng"));

            webDriver.Quit();
        }


        [TestMethod]
        public void GUIAD_09()
        {

            int waitingTime = 1000;

            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btnDH = webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr[1]/td[8]/a[2]/button"));
            btnDH.Click();

            Assert.IsTrue(webDriver.Title.Equals("Cập nhật khách hàng"));

            webDriver.Quit();
        }

        [TestMethod]
        public void GUIAD_10()
        {

            int waitingTime = 1000;

            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btnDH = webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr[1]/td[8]/a[3]/button"));
            btnDH.Click();

            Assert.IsTrue(webDriver.Title.Equals("Xóa khách hàng"));

            webDriver.Quit();
        }
    }
}
