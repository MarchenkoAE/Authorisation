﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace DataProviders.EntityFrameworkProviders.SqLite.Tests
{
    [TestClass()]
    public class SqLiteDbContextTests
    {
        [TestMethod()]
        public void OnConfiguringTest()
        {
            SqLiteDbContext context = new SqLiteDbContext();
            Assert.IsTrue(File.Exists("C:\\0\\Data.db"));
        }
    }
}