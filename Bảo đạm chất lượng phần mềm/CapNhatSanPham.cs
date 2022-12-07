using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class CapNhatSanPham
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
        public void CNSP_01()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("TenMH"));
            dd.SendKeys("Dell XPS");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenMH")).Clear();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenMH")).SendKeys("Dell XP");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("TenMH"));
            da.SendKeys("Dell XP");
            da.Submit();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr/td[1]")).Text.Equals("Dell XP"));
        }

        [TestMethod]
        public void CNSP_02()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("TenMH"));
            dd.SendKeys("Dell XP");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("IDLoaiMH")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDLoaiMH"));
                dropdown.FindElement(By.XPath("//option[. = 'Màn hình']")).Click();
            }
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("TenMH"));
            da.SendKeys("Dell XP");
            da.Submit();
            Thread.Sleep(waitingTime);           

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr/td[2]")).Text.Equals("Màn hình"));
        }

        [TestMethod]
        public void CNSP_03()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("TenMH"));
            dd.SendKeys("Dell XP");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("MoTa")).Clear();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("MoTa")).SendKeys("xyz");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("TenMH"));
            da.SendKeys("Dell XP");
            da.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-success")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[4]/div")).Text.Equals("xyz"));
        }

        [TestMethod]
        public void CNSP_04()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("TenMH"));
            dd.SendKeys("Dell XP");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("MoTaChiTiet")).Clear();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("MoTaChiTiet")).SendKeys("xyz123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("TenMH"));
            da.SendKeys("Dell XP");
            da.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-success")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[5]/div")).Text.Equals("xyz123"));

        }

        [TestMethod]
        public void CNSP_05()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("TenMH"));
            dd.SendKeys("Dell XP");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DonGia")).Clear();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DonGia")).SendKeys("200");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("TenMH"));
            da.SendKeys("Dell XP");
            da.Submit();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr/td[3]")).Text.Equals("200 VND"));
        }

        [TestMethod]
        public void CNSP_06()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("TenMH"));
            dd.SendKeys("Dell XP");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DonGia")).Clear();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DonGia")).SendKeys("-200");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("TenMH"));
            da.SendKeys("Dell XP");
            da.Submit();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/div[5]/div/span")).Text.Equals("The field DonGia must be between 1 and 2147483647."));
        }

        [TestMethod]
        public void CNSP_07()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("TenMH"));
            dd.SendKeys("Dell XP");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("5/10/2022");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("TenMH"));
            da.SendKeys("Dell XP");
            da.Submit();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr/td[5]")).Text.Equals("5/10/2022"));
        }

        [TestMethod]
        public void CNSP_08()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("TenMH"));
            dd.SendKeys("Dell XP");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SoLuong")).Clear();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SoLuong")).SendKeys("5");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("TenMH"));
            da.SendKeys("Dell XP");
            da.Submit();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr/td[4]")).Text.Equals("5"));            
        }

        [TestMethod]
        public void CNSP_09()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("TenMH"));
            dd.SendKeys("Dell XP");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-warning")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SoLuong")).Clear();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SoLuong")).SendKeys("-5");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/button")).Click();
            var da = webDriver.FindElement(By.Name("TenMH"));
            da.SendKeys("Dell XP");
            da.Submit();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div/div/div/div[7]/div/span")).Text.Equals("The field SoLuong must be between 1 and 2147483647."));
        }

        //[TestMethod]
        //public void CNSP_10()
        //{
        //    Login();

        //    int waitingTime = 1000;
        //    var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
        //    sideBar.Click();
        //    Thread.Sleep(waitingTime);
        //    webDriver.Manage().Window.Maximize();
        //    Thread.Sleep(waitingTime);
        //    var dd = webDriver.FindElement(By.Name("TenMH"));
        //    dd.SendKeys("Dell XP123");
        //    dd.Submit();
        //    webDriver.FindElement(By.CssSelector(".btn-outline-danger")).Click();
        //    webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
        //    var da = webDriver.FindElement(By.Name("TenMH"));
        //    da.SendKeys("Dell XP123");
        //    da.Submit();
        //    Thread.Sleep(waitingTime);

        //    Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr[1]/td[1]")).Text.Equals(""));
        //}

    }
}