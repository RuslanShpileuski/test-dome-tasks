/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	7. Account Test

	Using only NUnit's Assert.AreEqual method, write tests for the Account class that cover the following cases:

		The Deposit and Withdraw methods will not accept negative numbers.
		Account cannot overstep its overdraft limit.
		The Deposit and Withdraw methods will deposit or withdraw the correct amount, respectively.
		The Withdraw and Deposit methods return the correct results.
*/

namespace TestDome.Tasks
{
	public class Account
	{
		public double Balance { get; private set; }
		public double OverdraftLimit { get; private set; }

		public Account(double overdraftLimit)
		{
			OverdraftLimit = overdraftLimit > 0 ? overdraftLimit : 0;
			Balance = 0;
		}

		public bool Deposit(double amount)
		{
			if (amount >= 0)
			{
				Balance += amount;

				return true;
			}

			return false;
		}

		public bool Withdraw(double amount)
		{
			if (Balance - amount >= -OverdraftLimit && amount >= 0)
			{
				Balance -= amount;
				return true;
			}

			return false;
		}
	}
}