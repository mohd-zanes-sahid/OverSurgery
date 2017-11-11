using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;

namespace OverSurgeryUnitTest
{
    [TestClass]
    public class UnitTestGPHandler
    {
        [TestMethod]
        public void TestAddNewGP()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            GeneralPractitioner gp = new GeneralPractitioner();
            gp.Name = "Will Smith";
            gp.Status = 1;
            gp.DateJoined = new DateTime(2017, 1, 15, 0,0,0);
            gp.LoginName = "smith";
            gp.Password = "smith123";

            GPHandler gpHnd = new GPHandler();
            int resp2 = gpHnd.addNewGP(dbC.getConn(), gp);

        }
    }
}
