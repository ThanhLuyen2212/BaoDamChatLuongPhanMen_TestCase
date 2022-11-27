using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class DangKy
    {
        [TestMethod]
        public void DK_01()
        {
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("http://thanhluyen221200-001-site1.gtempurl.com/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
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

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);



            string URL = webDriver.Url;
            Assert.AreEqual(URL, "http://thanhluyen221200-001-site1.gtempurl.com/Login");
        }
    }
}
