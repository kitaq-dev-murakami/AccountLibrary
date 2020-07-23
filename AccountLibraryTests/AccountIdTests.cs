using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AccountLibrary.Tests
{
    [TestClass()]
    public class AccountIdTests
    {
        [TestMethod()]
        public void Idが10文字の場合OK()
        {
            var accountId = new AccountId("123456789A");
        }

        [TestMethod()]
        public void Idに設定した値が値オブジェクトのvalueから取得できる()
        {
            const string value = "123456789A";
            var accountId = new AccountId(value);
            Assert.AreEqual(value, accountId.Value);
        }

        [TestMethod()]
        public void Idがnullの場合ArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new AccountId(null));
        }

        [TestMethod()]
        public void Idが空の場合ArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new AccountId(""));
        }

        [TestMethod()]
        public void Idが10文字以外の場合ArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new AccountId("123456789"));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new AccountId("123456789@@@"));
        }

        [TestMethod()]
        public void Idは半角英字と半角数字で構成されるArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new AccountId("あいうえおかきくけこ"));
            Assert.ThrowsException<ArgumentException>(() => new AccountId("0123456789"));
            Assert.ThrowsException<ArgumentException>(() => new AccountId("abcdefghij"));
            Assert.ThrowsException<ArgumentException>(() => new AccountId("@@@@@#####"));
        }
    }
}