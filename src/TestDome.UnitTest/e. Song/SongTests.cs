namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class SongTests
	{
		[TestMethod]
		public void Song_IsRepeatingPlaylist()
		{
			// Arrange.
			var first = new Song("Hello");
			var second = new Song("Eye of the tiger");

			first.NextSong = second;
			second.NextSong = first;

			// Act.
			var actual = first.IsRepeatingPlaylist();

			// Assert.
			Assert.IsTrue(actual);
		}
	}
}