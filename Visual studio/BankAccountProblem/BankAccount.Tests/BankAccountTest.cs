using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BankAccount.Tests
{
    [TestFixture]
    public class BankAccountTest
    {
        const decimal AMOUNT = 200;
        private BankAccount account;

        [SetUp]
        public void TestInit()
        {
            this.account = new BankAccount();
        }
        [Test]
        public void ValidateDepositAmount()
        {
            //BankAccount account = new BankAccount();

            account.Deposit(AMOUNT);
            account.Deposit(AMOUNT);

            var expectedResult = AMOUNT * 2;
            var actualResult = account.Balance;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void AccountInitilizeWithPositiveValue()
        {
            account = new BankAccount(23, AMOUNT);

            var expectedResult = AMOUNT;
            var actualResult = account.Balance;
            Assert.AreEqual(expectedResult, actualResult, "Smeetkata ne se inicializira s podadenata syma.");
        }
        [Test]
        public void Deposit_AddZeroAmount_ShouldThrow()
        {
            //BankAccount account = new BankAccount();

            Assert.Throws<System.ArgumentException>(() => account.Deposit(0));
        }
        [Test]
        public void Withdraw_GetZeroAmomunt_ShouldThrow()
        {
            //BankAccount acc = new BankAccount();
            Assert.Throws<System.ArgumentException>(() => account.Withdraw(0));

        }
        [Test]
        public void Withdraw_GetZeroOrNegativeAmount_ShouldThrow()
        {
            account = new BankAccount(23, AMOUNT);
            account.Deposit(AMOUNT);
            account.Deposit(AMOUNT);

            var expectedResurlt = (AMOUNT * 2);
            var actualReelt = account.Balance;

            Assert.Throws<System.ArgumentException>(() => account.Withdraw(+AMOUNT));
        }

        [Test]
        public void Withdraw_GetMoney_ValidateBalance()
        {
            BankAccount account = new BankAccount(12, AMOUNT);
            account.Withdraw(AMOUNT);
            Assert.AreEqual(0, account.Balance);
        }
        [Test]
        public CodeIdentifier TransferMoney_ToSameAccount_ShouldThrow()
        {
            Assert.Throws<System.InvalidOperationException>(() => account.TransferMoney(account, AMOUNT));
        }
        [Test]
        public void TransferMoney_ToSameAccount_ShouldTransfer()
        {
            BankAccount otherAcc = new BankAccount();

            account.TransferMoney(otherAcc, AMOUNT);
            var exp = AMOUNT;
            var actualResult = otherAcc.Balance;

            Assert.AreEquals(exp, actualResult);
        }
    }
}
