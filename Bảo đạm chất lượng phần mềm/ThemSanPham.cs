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
        public void TSP_01()
        {
            Login();
                       
            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            By TaoSanPham = By.XPath("/html/body/div/div/div/div/div/div/a/button");
            var btnTaoSanPham = webDriver.FindElement(TaoSanPham);
            btnTaoSanPham.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenMH")).SendKeys("Dell XPS");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("IDLoaiMH")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDLoaiMH"));
                dropdown.FindElement(By.XPath("//option[. = 'Lap top']")).Click();
            }
            webDriver.FindElement(By.Name("MoTa")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("MoTaChiTiet")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DonGia")).SendKeys("100");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.Name("SoLuong")).SendKeys("10");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UploadImage1")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage2")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage3")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage4")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click(); 
            Thread.Sleep(waitingTime);
            var dd = webDriver.FindElement(By.Name("TenMH"));
            dd.SendKeys("Dell XPS");
            dd.Submit();
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr/td[1]")).Text.Equals("Dell XPS"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr/td[2]")).Text.Equals("Lap top"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr/td[3]")).Text.Equals("100 VND"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr/td[4]")).Text.Equals("10"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr/td[5]")).Text.Equals("5/12/2022"));
        }

        [TestMethod]
        public void TSP_02()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            By TaoSanPham = By.XPath("/html/body/div/div/div/div/div/div/a/button");
            var btnTaoSanPham = webDriver.FindElement(TaoSanPham);
            btnTaoSanPham.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("IDLoaiMH")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDLoaiMH"));
                dropdown.FindElement(By.XPath("//option[. = 'Lap top']")).Click();
            }
            webDriver.FindElement(By.Name("MoTa")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("MoTaChiTiet")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DonGia")).SendKeys("100");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.Name("SoLuong")).SendKeys("10");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UploadImage1")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage2")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage3")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage4")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.CssSelector(".form-group:nth-child(2) .field-validation-error")).Text.Equals("The TenMH field is required."));
        }

        [TestMethod]
        public void TSP_03()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            By TaoSanPham = By.XPath("/html/body/div/div/div/div/div/div/a/button");
            var btnTaoSanPham = webDriver.FindElement(TaoSanPham);
            btnTaoSanPham.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenMH")).SendKeys("Dell XPS");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("IDLoaiMH")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDLoaiMH"));
                dropdown.FindElement(By.XPath("//option[. = 'Lap top']")).Click();
            }

            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("MoTaChiTiet")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DonGia")).SendKeys("100");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.Name("SoLuong")).SendKeys("10");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UploadImage1")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage2")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage3")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage4")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[3]/div/span")).Text.Equals("The MoTa field is required."));
        }

        [TestMethod]
        public void TSP_04()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            By TaoSanPham = By.XPath("/html/body/div/div/div/div/div/div/a/button");
            var btnTaoSanPham = webDriver.FindElement(TaoSanPham);
            btnTaoSanPham.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenMH")).SendKeys("Dell XPS");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("IDLoaiMH")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDLoaiMH"));
                dropdown.FindElement(By.XPath("//option[. = 'Lap top']")).Click();
            }
            webDriver.FindElement(By.Name("MoTa")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DonGia")).SendKeys("100");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.Name("SoLuong")).SendKeys("10");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UploadImage1")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage2")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage3")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage4")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[4]/div/span")).Text.Equals("The MoTaChiTiet field is required."));
        }

        [TestMethod]
        public void TSP_05()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            By TaoSanPham = By.XPath("/html/body/div/div/div/div/div/div/a/button");
            var btnTaoSanPham = webDriver.FindElement(TaoSanPham);
            btnTaoSanPham.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenMH")).SendKeys("Dell XPS");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("IDLoaiMH")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDLoaiMH"));
                dropdown.FindElement(By.XPath("//option[. = 'Lap top']")).Click();
            }
            webDriver.FindElement(By.Name("MoTa")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("MoTaChiTiet")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.Name("SoLuong")).SendKeys("10");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UploadImage1")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage2")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage3")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage4")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[5]/div/span")).Text.Equals("The DonGia field is required."));
        }

        [TestMethod]
        public void TSP_06()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            By TaoSanPham = By.XPath("/html/body/div/div/div/div/div/div/a/button");
            var btnTaoSanPham = webDriver.FindElement(TaoSanPham);
            btnTaoSanPham.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenMH")).SendKeys("Dell XPS");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("IDLoaiMH")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDLoaiMH"));
                dropdown.FindElement(By.XPath("//option[. = 'Lap top']")).Click();
            }
            webDriver.FindElement(By.Name("MoTa")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("MoTaChiTiet")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DonGia")).SendKeys("-100");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.Name("SoLuong")).SendKeys("10");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UploadImage1")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage2")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage3")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage4")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);
           
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[5]/div/span")).Text.Equals("The field DonGia must be between 1 and 2147483647."));
        }

        [TestMethod]
        public void TSP_07()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            By TaoSanPham = By.XPath("/html/body/div/div/div/div/div/div/a/button");
            var btnTaoSanPham = webDriver.FindElement(TaoSanPham);
            btnTaoSanPham.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenMH")).SendKeys("Dell XPS");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("IDLoaiMH")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDLoaiMH"));
                dropdown.FindElement(By.XPath("//option[. = 'Lap top']")).Click();
            }
            webDriver.FindElement(By.Name("MoTa")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("MoTaChiTiet")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DonGia")).SendKeys("100");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SoLuong")).SendKeys("10");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UploadImage1")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage2")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage3")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage4")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);
            
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[6]/div/span")).Text.Equals("The NgayNhapHang field is required."));
        }

        [TestMethod]
        public void TSP_08()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            By TaoSanPham = By.XPath("/html/body/div/div/div/div/div/div/a/button");
            var btnTaoSanPham = webDriver.FindElement(TaoSanPham);
            btnTaoSanPham.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenMH")).SendKeys("Dell XPS");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("IDLoaiMH")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDLoaiMH"));
                dropdown.FindElement(By.XPath("//option[. = 'Lap top']")).Click();
            }
            webDriver.FindElement(By.Name("MoTa")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("MoTaChiTiet")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DonGia")).SendKeys("100");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UploadImage1")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage2")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage3")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage4")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);
            
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[7]/div/span")).Text.Equals("The SoLuong field is required."));
        }

        [TestMethod]
        public void TSP_09()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            By TaoSanPham = By.XPath("/html/body/div/div/div/div/div/div/a/button");
            var btnTaoSanPham = webDriver.FindElement(TaoSanPham);
            btnTaoSanPham.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenMH")).SendKeys("Dell XPS");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("IDLoaiMH")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDLoaiMH"));
                dropdown.FindElement(By.XPath("//option[. = 'Lap top']")).Click();
            }
            webDriver.FindElement(By.Name("MoTa")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("MoTaChiTiet")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DonGia")).SendKeys("100");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.Name("SoLuong")).SendKeys("-10");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UploadImage1")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage2")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage3")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.Name("UploadImage4")).SendKeys(@"D:\1.png");
            webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(waitingTime);
           
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[7]/div/span")).Text.Equals("The field SoLuong must be between 1 and 2147483647."));
        }

        [TestMethod]
        public void TSP_10()
        {
            Login();

            int waitingTime = 1000;
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
            sideBar.Click();
            By TaoSanPham = By.XPath("/html/body/div/div/div/div/div/div/a/button");
            var btnTaoSanPham = webDriver.FindElement(TaoSanPham);
            btnTaoSanPham.Click();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenMH")).SendKeys("Dell XPS");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("IDLoaiMH")).Click();
            {
                var dropdown = webDriver.FindElement(By.Id("IDLoaiMH"));
                dropdown.FindElement(By.XPath("//option[. = 'Lap top']")).Click();
            }
            webDriver.FindElement(By.Name("MoTa")).SendKeys("abc");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("MoTaChiTiet")).SendKeys("abc123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DonGia")).SendKeys("100");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Id("NgayNhapHang")).Click();
            webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
            webDriver.FindElement(By.Name("SoLuong")).SendKeys("10");
            Thread.Sleep(waitingTime);
           
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/div/div[8]/div/span")).Text.Equals("The HinhAnh field is required."));
        }

        //[TestMethod]
        //public void TSP_11()
        //{
        //    Login();

        //    int waitingTime = 1000;
        //    var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a"));
        //    sideBar.Click();
        //    By TaoSanPham = By.XPath("/html/body/div/div/div/div/div/div/a/button");
        //    var btnTaoSanPham = webDriver.FindElement(TaoSanPham);
        //    btnTaoSanPham.Click();
        //    Thread.Sleep(waitingTime);
        //    webDriver.Manage().Window.Maximize();
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.Name("TenMH")).SendKeys("Dell XPS");
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.Id("IDLoaiMH")).Click();
        //    {
        //        var dropdown = webDriver.FindElement(By.Id("IDLoaiMH"));
        //        dropdown.FindElement(By.XPath("//option[. = 'Lap top']")).Click();
        //    }
        //    webDriver.FindElement(By.Name("MoTa")).SendKeys("abc");
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.Name("MoTaChiTiet")).SendKeys("abc123");
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.Name("DonGia")).SendKeys("100");
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.Id("NgayNhapHang")).Click();
        //    webDriver.FindElement(By.Id("NgayNhapHang")).SendKeys("05-12-2022");
        //    webDriver.FindElement(By.Name("SoLuong")).SendKeys("10");
        //    Thread.Sleep(waitingTime);
        //    webDriver.FindElement(By.Name("UploadImage1")).SendKeys(@"D:\1.png");
        //    webDriver.FindElement(By.Name("UploadImage2")).SendKeys(@"D:\1.png");
        //    webDriver.FindElement(By.Name("UploadImage3")).SendKeys(@"D:\1.png");
        //    webDriver.FindElement(By.Name("UploadImage4")).SendKeys(@"D:\1.png");
        //    webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
        //    Thread.Sleep(waitingTime);
        //}

        
    }
}
