using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AccountLib;
using AccountLib.Model;

namespace AccountUnitTest1
{
    [TestClass]
    public class AccountUnitTest
    {
        [TestMethod]
        public void Account_ShouldInitialise_With3Parameters()
        {
            int expectedAccno = 101;
            string expectedName = "abc";
            double expectedBalance = 5000;

            Account acc = new Account(101, "abc", 5000);
            Assert.AreEqual(acc.AccountNumber, expectedAccno);
            Assert.AreEqual(acc.Name, expectedName);
            Assert.AreEqual(acc.Balance, expectedBalance);
        }

        [TestMethod]
        public void AfterCallingDeposit_AccountTheBalanceMustBeModified()
        {
            double expectedBalance = 1000;
            Account acc = new Account(102, "cde", 500);
            acc.Deposit(500);
            Assert.AreEqual(acc.Balance, expectedBalance);
        }

        [TestMethod]

        public void WithdrawShouldThrowExceptionIfFinalGoesLessThan500()
        {
            bool inSufficientfundsExceptionisThrown = false;
            Account acc = new Account(102, "cde", 500);
            try
            {
                acc.Withdrawl(500);
            }
            catch(InsufficientFundsException ex)
            {
                inSufficientfundsExceptionisThrown = true;
            }
            Assert.IsTrue(inSufficientfundsExceptionisThrown);
        }
    }
}
