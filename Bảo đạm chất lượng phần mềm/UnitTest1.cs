using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int waitingTime = 1000;
            By taiKhoan = By.Name("UserName");
            By matKhau = By.Name("Password");
           
            By loginButton = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input");
            /*tenLoai = By.Name("TENLOAISP");*/

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            //đăng ký
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Nguyen Ho Thanh Luyen");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("Luyen@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Nha Luyen");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("12/22/2000");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("luyen");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123456789");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();



            webDriver.FindElement(By.Name("UserName")).SendKeys("luyen");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123456789");
            Thread.Sleep(waitingTime);


            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);

            //chuyển đến link loại sản phẩm
            var sideBar = webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[2]/nav/ul/li[2]/a"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
        }


        [TestMethod]
        public void DangNhap()
        {
            int waitingTime = 1000;
            By taiKhoan = By.Name("UserName");
            By matKhau = By.Name("Password");
            /*loginButton = By.Name("BtnSubmit");*/
            By loginButton = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input");
            /* tenLoai = By.Name("TENLOAISP");*/

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("http://thanhluyen221200-001-site1.gtempurl.com/Login");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            // đăng nhập
            webDriver.FindElement(By.Name("UserName")).SendKeys("tr");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123ddd456789");
            Thread.Sleep(waitingTime);

            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);
            
            Assert.IsTrue(webDriver.FindElement(By.CssSelector(".text-danger")).Text.Equals("Sai thông tin tài khoản"));
          
        }
    }
}
