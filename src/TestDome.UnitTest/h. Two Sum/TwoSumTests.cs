namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System;
	using System.Collections.Generic;
	using TestDome.Tasks;

	[TestClass]
	public class TwoSumTests
	{
		[TestMethod]
		public void TwoSum_FindTwoSum()
		{
			// Arrange.
			var twoSum = new TwoSum();
			var numbers = new List<int>() { 3, 1, 5, 7, 5, 9 };
			var expected = Tuple.Create(0, 3);

			// Act.
			var actual = twoSum.FindTwoSum(numbers, 10);

			// Assert.
			Assert.AreEqual(expected, actual);
		}
	}
}