using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace T4.Test
{
    [TestClass]
    public class MySqlTest
    {
        [TestMethod]
        public void Test()
        {
            MySqlDbHelper mysql = new MySqlDbHelper();
            List<DbTable> dbTable = mysql.GetDbTables();
            Assert.IsNotNull(dbTable);
        }
    }
}
