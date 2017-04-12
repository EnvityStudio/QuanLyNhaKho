using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNhaKho.BUS;
using QuanLyNhaKho.VO;

namespace QuanLyNhaKhoUnitTest
{
    [TestClass]
    public class TestBus
    {
        [TestMethod]
        public void TestCheckAccountFalse1()
        {
            var userName = "abc";
            var matKhau = "123";

            var result = Bus.CheckAccount(new NhanVien()
            {
                UserName = userName,
                MatKhau = matKhau
            });

            Assert.IsTrue(result == false);
        }

        [TestMethod]
        public void TestCheckAccountFalse2()
        {
            var userName = "";
            var matKhau = "123";

            var result = Bus.CheckAccount(new NhanVien()
            {
                UserName = userName,
                MatKhau = matKhau
            });

            Assert.IsTrue(result == false);
        }

        [TestMethod]
        public void TestCheckAccountTrue1()
        {
            var userName = "admin";
            var matKhau = "123";

            var result = Bus.CheckAccount(new NhanVien()
            {
                UserName = userName,
                MatKhau = matKhau
            });

            Assert.IsTrue(result == true);
        }
    }
}
