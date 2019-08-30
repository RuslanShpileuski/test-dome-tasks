namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using TestDome.Tasks;

	[TestClass]
	public class SortedSearchTests
	{
		[TestMethod]
		public void SortedSearch_CountNumbers()
		{
			// Arrange.
			SortedSearch sortedSearch = new SortedSearch();

			// Act.
			int actual = sortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4);

			// Assert.
			Assert.AreEqual(2, actual);
		}
	}
}