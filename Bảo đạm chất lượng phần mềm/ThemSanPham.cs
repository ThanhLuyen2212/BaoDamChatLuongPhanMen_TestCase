using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class ThemSanPham
    {
        IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://thanhluyen221200-001-site1.gtempurl.com/Admin/AdminLogin?Areas=Admin");
        [TestMethod]
        public void Login()
        {
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
        public void TSP_01()
        {
            Login();
            int waitingTime = 1000;
            By TaoSanPham = By.XPath("/html/body/div/div/div/div/div/div/a/button");


            webDriver.Navigate().GoToUrl("http://thanhluyen221200-001-site1.gtempurl.com/Admin/AdminMatHangs/Index");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenMH")).SendKeys("Laptopabc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("IDLoaiMH")).SendKeys("1");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuandeptrai@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("07/07/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            var btnTaoSanPham = webDriver.FindElement(TaoSanPham);
            btnTaoSanPham.Click();
            Thread.Sleep(waitingTime);



            string URL = webDriver.Url;
            Assert.AreEqual(URL, "http://thanhluyen221200-001-site1.gtempurl.com/Login");
        }
    }
}
