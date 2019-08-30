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
			TwoSum twoSum = new TwoSum();
			List<int> numbers = new List<int>() { 3, 1, 5, 7, 5, 9 };
			Tuple<int, int> expected = Tuple.Create(0, 3);

			// Act.
			Tuple<int, int> actual = twoSum.FindTwoSum(numbers, 10);

			// Assert.
			Assert.AreEqual(expected, actual);
		}
	}
}