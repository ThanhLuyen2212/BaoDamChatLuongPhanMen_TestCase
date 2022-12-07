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
            // chức năng đăng ký thành công
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);


            string URL = webDriver.Url;
            Assert.AreEqual(URL, "https://localhost:44393/Login");
            
            webDriver.Quit();
        }


        [TestMethod]
        public void DK_02()
        {
            // chức năng đăng ký không nhập tên khách hàng
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
           
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);

            string s = "The TenKH field is required.";
            Assert.AreEqual(s,webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[2]/span")).Text);

            webDriver.Quit();
        }


        [TestMethod]
        public void DK_03()
        {
            // chức năng đăng ký không nhập sdt
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);            
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[2]/span"));

            string s = "The SDT field is required.";
            Assert.AreEqual(s, webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[3]/span")).Text);

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_04()
        {
            // chức năng đăng ký không nhập địa chỉ giao hàng 
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);            
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
                       
            string s = "The DiaChiGiaoHang1 field is required.";
            Assert.AreEqual(s, webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[5]/span")).Text);
            
            webDriver.Quit();
        }

        [TestMethod]
        public void DK_05()
        {
            // chức năng đăng ký không nhập email
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);            
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);


            string s = "The Eamail field is required.";
            Assert.AreEqual(s, webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/span")).Text);

            webDriver.Quit();
        }


        [TestMethod]
        public void DK_06()
        {
            // chức năng đăng ký không nhập ngày sinh
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);



            string s = "The NgaySinh field is required.";
            Assert.AreEqual(s, webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[7]/span")).Text);

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_07()
        {
            // chức năng đăng ký không nhập tên đăng nhập
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);


            string s = "The UserName field is required.";
            Assert.AreEqual(s, webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[7]/span")).Text);

            webDriver.Quit();
        }


        [TestMethod]
        public void DK_08()
        {
            // chức năng đăng ký không nhập mật khẩu
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);            

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);

            string s = "The Password field is required.";
            Assert.AreEqual(s, webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[8]/span")).Text);

            webDriver.Quit();
        }


        [TestMethod]
        public void DK_09()
        {
            // chức năng đăng ký thông báo username đã tồn tại 
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567899");
            Thread.Sleep(waitingTime);

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);


            string s = "Tên đăng nhập đã tồn tại.";
            Assert.AreEqual(s, webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[8]/span")).Text);

            webDriver.Quit();
        }


        [TestMethod]
        public void DK_10()
        {
            // chức năng đăng ký nhập paswrod với 8 ký tự
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai1");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("12345678");
            Thread.Sleep(waitingTime);

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);

            string URL = webDriver.Url;
            Assert.AreEqual(URL, "https://localhost:44393/Login");

            webDriver.Quit();
        }


        [TestMethod]
        public void DK_11()
        {
            // chức năng đăng ký thành công nhập password với 16 ký tự
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai2");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890123456");
            Thread.Sleep(waitingTime);

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);


            string URL = webDriver.Url;
            Assert.AreEqual(URL, "https://localhost:44393/Login");

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_12()
        {
            // chức năng đăng ký thất bại với nhập password với 7 ký tự
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai3");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567");
            Thread.Sleep(waitingTime);

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);


            string s = "Thông báo password không hợp lệ";
            Assert.AreEqual(s, webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[8]/span")).Text);

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_13()
        {
            // chức năng đăng ký thất bại nhập password với 17 ký tự
            int waitingTime = 1000;

            By loginRegister = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login/Register");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai4");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("12345678901234567");
            Thread.Sleep(waitingTime);

            var btnRegister = webDriver.FindElement(loginRegister);
            btnRegister.Click();
            Thread.Sleep(waitingTime);


            string s = "Thông báo password không hợp lệ";
            Assert.AreEqual(s, webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[8]/span")).Text);


            webDriver.Quit();
        }
    }
}
