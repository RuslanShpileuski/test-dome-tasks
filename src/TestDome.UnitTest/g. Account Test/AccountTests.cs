/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	7. Account Test

	Using only NUnit's Assert.AreEqual method, write tests for the Account class that cover the following cases:

		The Deposit and Withdraw methods will not accept negative numbers.
		Account cannot overstep its overdraft limit.
		The Deposit and Withdraw methods will deposit or withdraw the correct amount, respectively.
		The Withdraw and Deposit methods return the correct results.
*/

namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using TestDome.Tasks;

	[TestClass]
	public class Tester
	{
		private double epsilon = 1e-6;

		[TestMethod]
		public void Account_CannotHaveNegativeOverdraftLimit()
		{
			// Arrange.
			// Act.
			Account account = new Account(-20);

			// Assert.
			Assert.AreEqual(0, account.OverdraftLimit, epsilon);
		}

		[TestMethod]
		public void Deposit_DoesntAcceptNegativeValue()
		{
			// Arrange.
			Account account = new Account(20);

			// Act.
			bool result = account.Deposit(-10);

			// Assert.
			Assert.AreEqual(0, account.Balance, epsilon);
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Withdraw_DoesntAcceptNegativeValue()
		{
			// Arrange.
			Account account = new Account(20);

			// Act.
			bool result = account.Withdraw(-10);

			// Assert.
			Assert.AreEqual(0, account.Balance, epsilon);
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Deposit_PositiveValueOk()
		{
			// Arrange.
			Account account = new Account(20);

			// Act.
			bool result = account.Deposit(10);

			// Assert.
			Assert.AreEqual(10, account.Balance, epsilon);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void Withdraw_PositiveValueOverdraftOk()
		{
			// Arrange.
			Account account = new Account(20);

			// Act.
			bool result = account.Withdraw(10);

			// Assert.
			Assert.AreEqual(-10, account.Balance, epsilon);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void Withdraw_PositiveValueBalanceOk()
		{
			// Arrange. 
			Account account = new Account(0);
			account.Deposit(20);

			// Act.
			bool result = account.Withdraw(10);

			// Assert.
			Assert.AreEqual(10, account.Balance, epsilon);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void Account_CannotOverstepOverdraftLimit()
		{
			// Arrange.
			Account account = new Account(20);

			// Act.
			bool result = account.Withdraw(30);

			// Assert.
			Assert.AreEqual(0, account.Balance, epsilon);
			Assert.IsFalse(result);
		}
	}
}