/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	8. Two Sum

	Write a function that, when passed a list and a target sum, returns, efficiently with respect to time used, two distinct zero-based indices of any two of the numbers, whose sum is equal to the target sum. If there are no two numbers, the function should return null.

	For example, FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10) should return a Tuple<int, int> containing any of the following pairs of indices:

		0 and 3 (or 3 and 0) as 3 + 7 = 10
		1 and 5 (or 5 and 1) as 1 + 9 = 10
		2 and 4 (or 4 and 2) as 5 + 5 = 10
*/

namespace TestDome.Tasks
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// The two sum.
	/// </summary>
	public class TwoSum
	{
		/// <summary>
		/// Finds the two sum.
		/// </summary>
		/// <param name="list">The list.</param>
		/// <param name="sum">The sum.</param>
		/// <returns></returns>
		public Tuple<int, int> FindTwoSum(IList<int> list, int sum)
		{
			Dictionary<int, int> dict = new Dictionary<int, int>();

			for (int i = 0; i < list.Count; i++)
			{
				int diff = sum - list[i];

				if (dict.TryGetValue(diff, out int j))
				{
					return Tuple.Create(j, i);
				}

				dict[list[i]] = i;
			}

			return null;
		}
	}
}