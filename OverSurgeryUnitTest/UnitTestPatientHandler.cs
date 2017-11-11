using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;
using MySql.Data.MySqlClient;

namespace OverSurgeryUnitTest
{
    [TestClass]
    public class UnitTestPatientHandler
    {
        [TestMethod]
        public void TestAddNewPatient()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Patient pat = new Patient();
            pat.Name = "Jack Sparrow";
            pat.Age = 23;
            pat.Mykad = "091209102309";

            PatientHandler pHnd = new PatientHandler();
            int resp2 = pHnd.addNewPatient(dbC.getConn(), pat);
            Assert.IsNotNull(resp2);

        }
    }
}
