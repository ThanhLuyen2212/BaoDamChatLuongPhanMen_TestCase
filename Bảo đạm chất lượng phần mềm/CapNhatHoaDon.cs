using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class CapNhatHoaDon
    {
        IWebDriver webDriver = new ChromeDriver();

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
        public void CNHD_01()
        {
            Login();
            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[4]/a/span[2]"));
            sideBar.Click();
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            var btnDH = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[4]/div/ul/li[1]/a"));
            btnDH.Click();
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("tenKH"));
            dd.SendKeys("Tuan");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiNhanHang")).Clear();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiNhanHang")).SendKeys("HCM");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            Thread.Sleep(waitingTime);
            var da = webDriver.FindElement(By.Name("tenKH"));
            da.SendKeys("Tuan");
            da.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-success")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/div")).Text.Equals("HCM"));
        }

        [TestMethod]
        public void CNHD_02()
        {
            Login();
            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[4]/a/span[2]"));
            sideBar.Click();
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            var btnDH = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[4]/div/ul/li[1]/a"));
            btnDH.Click();
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("tenKH"));
            dd.SendKeys("Tuan");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("IDPT")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDPT"));
                dropdown.FindElement(By.XPath("//option[. = 'Chuyển khoản']")).Click();
            }
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            Thread.Sleep(waitingTime);
            var da = webDriver.FindElement(By.Name("tenKH"));
            da.SendKeys("Tuan");
            da.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-success")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[9]/div")).Text.Equals("Chuyển khoản"));
            webDriver.Quit();
        }

        [TestMethod]
        public void CNHD_03()
        {
            Login();
            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[4]/a/span[2]"));
            sideBar.Click();
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            var btnDH = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[4]/div/ul/li[1]/a"));
            btnDH.Click();
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("tenKH"));
            dd.SendKeys("Tuan");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("IDTrangThai")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDTrangThai"));
                dropdown.FindElement(By.XPath("//option[. = 'Giao hàng thành công']")).Click();
            }
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            Thread.Sleep(waitingTime);
            var da = webDriver.FindElement(By.Name("tenKH"));
            da.SendKeys("Tuan");
            da.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-success")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[8]/div")).Text.Equals("Giao hàng thành công"));
            webDriver.Quit();
        }

        [TestMethod]
        public void CNHD_04()
        {
            Login();
            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[4]/a/span[2]"));
            sideBar.Click();
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            var btnDH = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[4]/div/ul/li[1]/a"));
            btnDH.Click();
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("tenKH"));
            dd.SendKeys("Tuan");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("TrangThaiThanhToan")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("TrangThaiThanhToan"));
                dropdown.FindElement(By.XPath("//option[. = 'True']")).Click();
            }
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            Thread.Sleep(waitingTime);
            var da = webDriver.FindElement(By.Name("tenKH"));
            da.SendKeys("Tuan");
            da.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-success")).Click();
            Thread.Sleep(waitingTime);



           hê lô

            Assert.IsTrue(webDriver.FindElement(By.CssSelector(".tri-state")).Selected.ToString().Equals("True"));

            webDriver.Quit();
        }
    }
}
