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
    public class AccountPasswordTests
    {
        [TestMethod()]
        public void パスワードがNullの場合ArgumentExceptionが発生すること()
        {
            Assert.ThrowsException<ArgumentException>(() => new AccountPassword(null));
        }

        [TestMethod()]
        public void パスワードが空の場合ArgumentExceptionが発生すること()
        {
            Assert.ThrowsException<ArgumentException>(() => new AccountPassword(""));
        }

        [TestMethod()]
        public void パスワードの文字数は8文字未満のときArgumentExceptionが発生すること()
        {
            Assert.ThrowsException<ArgumentException>(() => new AccountPassword("1234567"));
        }

        [TestMethod()]
        public void パスワードは半角英字と半角数字かつ大文字1文字以上で構成されていない場合ArgumentExceptionが発生すること()
        {
            Assert.ThrowsException<ArgumentException>(() => new AccountPassword("12345678"));
            Assert.ThrowsException<ArgumentException>(() => new AccountPassword("aaaaaaaa"));
            Assert.ThrowsException<ArgumentException>(() => new AccountPassword("AAAAAAAA"));
            Assert.ThrowsException<ArgumentException>(() => new AccountPassword("ＡＡＡＡＡＡＡＡ"));
            Assert.ThrowsException<ArgumentException>(() => new AccountPassword("********"));
        }

        [TestMethod()]
        public void パスワードの要件が満たせている()
        {
            const string password = "a1Abbbbbbbb";
            var accountPassword = new AccountPassword(password);
            Assert.AreEqual(password, accountPassword.Value);
        }
    }
}