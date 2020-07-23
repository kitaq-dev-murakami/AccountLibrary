using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void AccountTest()
        {
            var account = new Account();
        }

        [TestMethod()]
        public void 引数がnullの場合ArgumentException()
        {
            var account = new Account();
            Assert.ThrowsException<ArgumentException>(() => account.Create(null, null));
        }

        [TestMethod()]
        public void 引数が空の場合ArgumentException()
        {
            var account = new Account();
            Assert.ThrowsException<ArgumentException>(() => account.Create("", ""));
        }
    }
}