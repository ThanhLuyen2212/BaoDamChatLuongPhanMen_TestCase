using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.DevTools.V105.CSS;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class ThemKH
    {
        IWebDriver webDriver = new ChromeDriver();

        [TestMethod]
        public void Login()
        {
            webDriver.Navigate().GoToUrl("http://thanhluyen221200-001-site1.gtempurl.com/Admin/AdminLogin?Areas=Admin");
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
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();

            By TaoKH = By.XPath("/html/body/div/div/div/div/div/div/a/button");
            var btnTaoKhachHang = webDriver.FindElement(TaoKH);
            btnTaoKhachHang.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("ThaiTuan");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("12345678900");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abccccccc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abcccccccccc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuankute");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("ahihituanne");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();

            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("tenKH"));
            dd.SendKeys("ThaiTuan");
            dd.Submit();
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr[1]/td[1]")).Text.Equals("ThaiTuan"));
        }
    }
}
