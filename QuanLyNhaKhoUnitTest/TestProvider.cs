using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNhaKho.DAO;
using System.Data;

namespace QuanLyNhaKhoUnitTest
{
    [TestClass]
    public class TestProvider
    {
        [TestMethod]
        public void TestDataProviderQueryMethod()
        {
            DataProvider provider = new DataProvider();
            DataTable dt = DataProvider.Query("Select * from NhanVien");
            Console.Write(dt);
        }
    }
}
