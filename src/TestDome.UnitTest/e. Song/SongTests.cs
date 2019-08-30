namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using TestDome.Tasks;

	[TestClass]
	public class SongTests
	{
		[TestMethod]
		public void Song_IsRepeatingPlaylist()
		{
			// Arrange.
			Song first = new Song("Hello");
			Song second = new Song("Eye of the tiger");

			first.NextSong = second;
			second.NextSong = first;

			// Act.
			bool actual = first.IsRepeatingPlaylist();

			// Assert.
			Assert.IsTrue(actual);
		}
	}
}