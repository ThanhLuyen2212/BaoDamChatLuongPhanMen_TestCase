using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class CapNhatKH
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
        public void CNKH_01()
        {
            Login();
            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();
            webDriver.Manage().Window.Maximize();
            var dd = webDriver.FindElement(By.Name("tenKH"));
            dd.SendKeys("ThaiTuan");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).Clear();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuan");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgaySinh")).Click();
            webDriver.FindElement(By.Id("NgaySinh")).SendKeys("9/29/2001");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("tenKH"));
            da.SendKeys("Tuan");
            da.Submit();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr[1]/td[1]")).Text.Equals("Tuan"));
        }

        [TestMethod]
        public void CNKH_02()
        {
            Login();
            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();
            webDriver.Manage().Window.Maximize();
            var dd = webDriver.FindElement(By.Name("tenKH"));
            dd.SendKeys("Tuan");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).Clear();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("0123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgaySinh")).Click();
            webDriver.FindElement(By.Id("NgaySinh")).SendKeys("9/29/2001");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("tenKH"));
            da.SendKeys("Tuan");
            da.Submit();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr[1]/td[2]")).Text.Equals("0123456789"));


        }

        [TestMethod]
        public void CNKH_03()
        {
            Login();
            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();
            webDriver.Manage().Window.Maximize();
            var dd = webDriver.FindElement(By.Name("tenKH"));
            dd.SendKeys("Tuan");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).Clear();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgaySinh")).Click();
            webDriver.FindElement(By.Id("NgaySinh")).SendKeys("9/29/2001");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("tenKH"));
            da.SendKeys("Tuan");
            da.Submit();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr[1]/td[3]")).Text.Equals("Lâm Đồng"));
        }

        [TestMethod]
        public void CNKH_04()
        {
            Login();
            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();
            webDriver.Manage().Window.Maximize();
            var dd = webDriver.FindElement(By.Name("tenKH"));
            dd.SendKeys("Tuan");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).Clear();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("HCM");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgaySinh")).Click();
            webDriver.FindElement(By.Id("NgaySinh")).SendKeys("9/29/2001");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("tenKH"));
            da.SendKeys("Tuan");
            da.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-success")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[5]/div")).Text.Equals("HCM"));
        }

        [TestMethod]
        public void CNKH_05()
        {
            Login();
            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();
            webDriver.Manage().Window.Maximize();
            var dd = webDriver.FindElement(By.Name("tenKH"));
            dd.SendKeys("Tuan");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).Clear();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgaySinh")).Click();
            webDriver.FindElement(By.Id("NgaySinh")).SendKeys("9/29/2001");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("tenKH"));
            da.SendKeys("Tuan");
            da.Submit();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr[1]/td[4]")).Text.Equals("thaituan@123"));
        }

        [TestMethod]
        public void CNKH_06()
        {
            Login();
            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();
            webDriver.Manage().Window.Maximize();
            var dd = webDriver.FindElement(By.Name("tenKH"));
            dd.SendKeys("Tuan");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgaySinh")).Click();
            webDriver.FindElement(By.Id("NgaySinh")).SendKeys("10/29/2000");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("tenKH"));
            da.SendKeys("Tuan");
            da.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-success")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[7]/div")).Text.Equals("10/29/2000"));
        }
    }
}
