/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	2. Merge Names

	Implement the UniqueNames method. When passed two arrays of names, it will return an array containing the names that appear in either or both arrays. The returned array should have no duplicates.
	For example, calling MergeNames.UniqueNames(new string[]{'Ava', 'Emma', 'Olivia'}, new string[]{'Olivia', 'Sophia', 'Emma'}) should return an array containing Ava, Emma, Olivia, and Sophia in any order.
*/

namespace TestDome.Tasks
{
	using System.Linq;

	public class MergeNames
	{
		public string[] UniqueNames(string[] names1, string[] names2)
		{
			var tempNames1 = names1.Distinct().ToList();

			tempNames1.AddRange(names2.Distinct());

			return tempNames1.Distinct().ToArray();
		}

		public bool IsNullOrEmpty(string[] arr)
		{
			return (arr == null) && arr.Length == 0;
		}
	}
}