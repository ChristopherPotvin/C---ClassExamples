using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingData.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void DepositTestSuccess()
        {
            // Arrange

            decimal initBalance = 100;
            Account acct = new Account(initBalance);
            decimal amount = 50;
            decimal expectedBalance = 150;
            decimal actualBalance;

            // Act

            acct.Deposit(amount);
            actualBalance = acct.Balance;

            // Assert

            Assert.AreEqual(actualBalance, expectedBalance);
        }


        [TestMethod()]
        public void DepositTestNegativeAmount()
        {
            // Arrange

            decimal initBalance = 100;
            Account acct = new Account(initBalance);
            decimal amount = -50;
            decimal expectedBalance = 100;
            decimal actualBalance;

            // Act

            acct.Deposit(amount);
            actualBalance = acct.Balance;

            // Assert

            Assert.AreEqual(actualBalance, expectedBalance);
        }
        [TestMethod()]
        public void WithdrawTestSuccess()
        {
            // Arrange

            decimal initBalance = 100;
            Account acct = new Account(initBalance);
            decimal amount = 25;
            decimal expectedBalance = 75;
            decimal actualBalance;
            bool expectedResult = true;
            bool actualResult;

            // Act

            actualResult = acct.Withdraw(amount);
            actualBalance = acct.Balance;

            // Assert

            Assert.AreEqual(actualBalance, expectedBalance);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod()]
        public void WithdrawTestFailure()
        {
            // Arrange

            decimal initBalance = 100;
            Account acct = new Account(initBalance);
            decimal amount = 125;
            decimal expectedBalance = 100;
            decimal actualBalance;
            bool expectedResult = false;
            bool actualResult;

            // Act

            actualResult = acct.Withdraw(amount);
            actualBalance = acct.Balance;

            // Assert

            Assert.AreEqual(actualBalance, expectedBalance);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod()]
        public void WithdrawTestNegativeAmount()
        {
            // Arrange

            decimal initBalance = 100;
            Account acct = new Account(initBalance);
            decimal amount = -25;
            decimal expectedBalance = 100;
            decimal actualBalance;
            bool expectedResult = false;
            bool actualResult;

            // Act

            actualResult = acct.Withdraw(amount);
            actualBalance = acct.Balance;

            // Assert

            Assert.AreEqual(actualBalance, expectedBalance);
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}