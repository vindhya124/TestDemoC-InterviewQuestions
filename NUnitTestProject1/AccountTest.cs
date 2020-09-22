using NUnit.Framework;
using TestConsoleApplication;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void AccountCannotHaveNegativeOverdraftLimit()
        {
            Account account = new Account(-20);
            var depositResult = account.Deposit(-1);

            var withdrawResult = account.Withdraw(-2);
            Assert.False(depositResult);
            Assert.False(withdrawResult);

        }

        [Test]
        public void AccountCannotOverstepOverDraftLimit()
        {
            Account account = new Account(-20);
            Assert.AreEqual(0, account.OverdraftLimit);
        }

        [Test]
        public void AccountDepositWithdrawCorrectAmount()
        {
            Account account = new Account(10);

            account.Deposit(1000);
            Assert.AreEqual(1000d, account.Balance);

            account.Withdraw(500);
            Assert.AreEqual(500d, account.Balance);
        }

        [Test]
        public void AccountDepositWithdrawCorrectResult()
        {
            Account account = new Account(10);

            var balance = account.Deposit(1000);
            var withDraw = account.Withdraw(500);

            Assert.IsTrue(balance);
            Assert.IsTrue(withDraw);

        }
    }
}