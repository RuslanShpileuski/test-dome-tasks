/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	2. Merge Names

	Implement the UniqueNames method. When passed two arrays of names, it will return an array containing the names that appear in either or both arrays. The returned array should have no duplicates.
	For example, calling MergeNames.UniqueNames(new string[]{'Ava', 'Emma', 'Olivia'}, new string[]{'Olivia', 'Sophia', 'Emma'}) should return an array containing Ava, Emma, Olivia, and Sophia in any order.
*/

namespace TestDome.Tasks
{
	using System.Linq;

	/// <summary>
	/// The merge names.
	/// </summary>
	public class MergeNames
	{
		/// <summary>
		/// Uniques the names.
		/// </summary>
		/// <param name="names1">The names1.</param>
		/// <param name="names2">The names2.</param>
		/// <returns>The result.</returns>
		public string[] UniqueNames(string[] names1, string[] names2)
		{
			return names1.Concat(names2).Distinct().ToArray();
		}
	}
}