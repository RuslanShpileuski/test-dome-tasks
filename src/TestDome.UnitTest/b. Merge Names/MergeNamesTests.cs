namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using TestDome.Tasks;

	[TestClass]
	public class MergeNamesTests
	{
		[TestMethod]
		public void MergeNames_FindUniqueNames()
		{
			// Arrange. 
			var names = new MergeNames();

			string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
			string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
			string[] expected = new[] { "Ava", "Emma", "Olivia", "Sophia" };

			// Act.
			var actual = names.UniqueNames(names1, names2);

			// Assert.
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}