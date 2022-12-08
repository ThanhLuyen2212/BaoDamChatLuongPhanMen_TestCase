using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class DatHang
    {

        IWebDriver webDriver = new ChromeDriver();

        [TestMethod]
        public void Login()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login");
            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuan");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123");
            Thread.Sleep(waitingTime);

            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();

            string URL = webDriver.Url;
            Assert.AreEqual(URL, "https://localhost:44393/");
        }


        [TestMethod]
        public void TestMethod1()
        {
            Login();
            int waitingTime = 1000;
            webDriver.FindElement(By.XPath("/html/body/section[2]/div/div[2]/div[1]/div/a/div/img")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/section/div/div/div[2]/div/div[2]/a")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/section/div/div/div/div/div[2]/div/div/form/input")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiNhanHang")).SendKeys("Nhà Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TrangThaiThanhToan")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("IDPT")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/form/section/div/div/div[1]/div/div/div[6]/div/div/div/select/option[2]"));

            /*webDriver.FindElement(By.Id("IDPT")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDPT"));
                dropdown.FindElement(By.XPath("//option[. = '2']")).Click();
            }*/
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/form/section/div/div/div[2]/div/button")).Click();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div[4]/h2")).Text.Equals("Chúc mừng bạn đã đặt hàng thành công "));
            Assert.AreEqual(webDriver.FindElement(By.XPath("/html/body/div[4]/h2")).Text ,"Chúc mừng bạn đã đặt hàng thành công");
            webDriver.Quit();
        }
    }
}
