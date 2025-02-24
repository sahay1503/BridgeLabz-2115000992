using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Problem5;
namespace Problem5Test
{
    [TestFixture]
    public class Class1
    {
        private DatabaseConnection db;

        [SetUp]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        [TearDown]
        public void Teardown()
        {
            db.Disconnect();
        }

        [Test]
        public void Test_Connection_Is_Established()
        {
            Assert.IsTrue(db.IsConnected(), "Database should be connected in Setup.");
        }

        [Test]
        public void Test_Connection_Is_Closed()
        {
            db.Disconnect();
            Assert.IsFalse(db.IsConnected(), "Database should be disconnected after calling Disconnect.");
        }

    }
}
