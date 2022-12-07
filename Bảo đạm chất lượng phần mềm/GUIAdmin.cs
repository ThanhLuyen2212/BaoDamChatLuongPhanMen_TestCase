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
        [TestMethod]
        public void GUIAD_01()
        {

            int waitingTime = 1000;

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/admin/adminlogin");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            Assert.IsTrue(webDriver.Title.Equals("Đăng nhập"));

            webDriver.Quit();
        }
    }
}
