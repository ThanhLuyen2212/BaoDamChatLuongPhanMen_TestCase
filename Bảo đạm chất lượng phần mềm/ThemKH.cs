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
        public void TKH_01()
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
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("9/29/2001");
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
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-success")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[2]/div")).Text.Equals("ThaiTuan"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/div")).Text.Equals("12345678900"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[4]/div")).Text.Equals("abc"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[5]/div")).Text.Equals("abc123"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[6]/div")).Text.Equals("thaituan@123"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[7]/div")).Text.Equals("9/29/2001"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[8]/div")).Text.Equals("tuankute"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[9]/div")).Text.Equals("ahihituanne"));
        }

        [TestMethod]
        public void TKH_02()
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

            webDriver.FindElement(By.Name("SDT")).SendKeys("12345678900");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("9/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuankute");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("ahihituanne");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[1]/div/span")).Text.Equals("The TenKH field is required."));
        }

        [TestMethod]
        public void TKH_03()
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
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("9/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuankute");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("ahihituanne");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[2]/div/span")).Text.Equals("The SDT field is required."));
        }

        [TestMethod]
        public void TKH_04()
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
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("9/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuankute");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("ahihituanne");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[3]/div/span")).Text.Equals("The DiaChiGiaoHang1 field is required."));
        }

        [TestMethod]
        public void TKH_05()
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
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("9/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuankute");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("ahihituanne");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[4]/div/span")).Text.Equals("The DiaChiGiaoHang2 field is required."));
        }

        [TestMethod]
        public void TKH_06()
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
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("9/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuankute");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("ahihituanne");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[5]/div/span")).Text.Equals("The Email field is required."));
        }

        //public void TSP_07()
        //{
        //    Login();
        //    int waitingTime = 1000;
        //    var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
        //    sideBar.Click();

        //    By TaoKH = By.XPath("/html/body/div/div/div/div/div/div/a/button");
        //    var btnTaoKhachHang = webDriver.FindElement(TaoKH);
        //    btnTaoKhachHang.Click();
        //    Thread.Sleep(waitingTime);
        //    webDriver.Manage().Window.Maximize();

        //    webDriver.FindElement(By.Name("TenKH")).SendKeys("ThaiTuan");
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.Name("SDT")).SendKeys("12345678900");
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abc");
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abc123");
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.Name("Email")).SendKeys("thaituan");
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.Name("NgaySinh")).SendKeys("9/29/2001");
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.Name("UserName")).SendKeys("tuankute");
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.Name("Password")).SendKeys("ahihituanne");
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
        //    Thread.Sleep(waitingTime);

        //    var dd = webDriver.FindElement(By.Name("tenKH"));
        //    dd.SendKeys("ThaiTuan");
        //    dd.Submit();
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.CssSelector(".btn-outline-success")).Click();
        //    Thread.Sleep(waitingTime);

        //    Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[2]/div")).Text.Equals("ThaiTuan"));
        //    Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/div")).Text.Equals("12345678900"));
        //    Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[4]/div")).Text.Equals("abc"));
        //    Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[5]/div")).Text.Equals("abc123"));
        //    Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[6]/div")).Text.Equals("thaituan@123"));
        //    Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[7]/div")).Text.Equals("9/29/2001"));
        //    Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[8]/div")).Text.Equals("tuankute"));
        //    Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[8]/div")).Text.Equals("ahihituanne"));
        //}

        [TestMethod]
        public void TKH_07()
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
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuankute");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("ahihituanne");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[6]/div/span")).Text.Equals("The NgaySinh field is required."));
        }

        [TestMethod]
        public void TKH_08()
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
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("9/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("ahihituanne");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[7]/div/span")).Text.Equals("The UserName field is required."));
        }

        [TestMethod]
        public void TKH_09()
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
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("9/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuankute");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[8]/div/span")).Text.Equals("The Password field is required."));
        }

        [TestMethod]
        public void TKH_10()
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

            webDriver.FindElement(By.Name("TenKH")).SendKeys("ThaiTuan1");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("12345678900");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("9/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuankute");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("12345678");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            var dd = webDriver.FindElement(By.Name("tenKH"));
            dd.SendKeys("ThaiTuan1");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-success")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[2]/div")).Text.Equals("ThaiTuan1"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/div")).Text.Equals("12345678900"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[4]/div")).Text.Equals("abc"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[5]/div")).Text.Equals("abc123"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[6]/div")).Text.Equals("thaituan@123"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[7]/div")).Text.Equals("9/29/2001"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[8]/div")).Text.Equals("tuankute"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[9]/div")).Text.Equals("12345678"));
        }

        [TestMethod]
        public void TKH_11()
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

            webDriver.FindElement(By.Name("TenKH")).SendKeys("ThaiTuan2");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("12345678900");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("9/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuankute");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("ahihituanne12345");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            var dd = webDriver.FindElement(By.Name("tenKH"));
            dd.SendKeys("ThaiTuan2");
            dd.Submit();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-outline-success")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[2]/div")).Text.Equals("ThaiTuan2"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/div")).Text.Equals("12345678900"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[4]/div")).Text.Equals("abc"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[5]/div")).Text.Equals("abc123"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[6]/div")).Text.Equals("thaituan@123"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[7]/div")).Text.Equals("9/29/2001"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[8]/div")).Text.Equals("tuankute"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[9]/div")).Text.Equals("ahihituanne12345"));
        }

        [TestMethod]
        public void TKH_12()
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
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("9/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuankute");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[8]/div/span")).Text.Equals("The field Password must be a string or array type with a minimum length of '8'."));
        }

        [TestMethod]
        public void TKH_13()
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
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang2")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("thaituan@123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("9/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuankute");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("ahihituanne123456");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[8]/div/span")).Text.Equals("The field Password must be a string or array type with a maximum length of '16'."));
        }
    }
}
