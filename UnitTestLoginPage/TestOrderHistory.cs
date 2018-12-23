using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;


namespace BookStoreLIB
{
    [TestClass]
    public class TestOrderHistory
    {
        ViewHistory history = new ViewHistory();
        DataSet orders;
        DataTable orderHistory;

        [TestMethod]
        public void TestOrderHistory1()
        {
            int uid = 7;
            int expectedCount = 7;

            orders = history.getOrders(uid);
            orderHistory = orders.Tables["UserOrders"];
            Assert.AreEqual(expectedCount, orderHistory.Rows.Count);
        }

        [TestMethod]
        public void TestOrderHistory2()
        {
            int oid = 59;
            int expectedCount = 2;

            orders = history.getDetails(oid);
            orderHistory = orders.Tables["OrderDetails"];
            Assert.AreEqual(expectedCount, orderHistory.Rows.Count);
        }
    }
}
