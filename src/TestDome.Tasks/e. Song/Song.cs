/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	5. Song

	A playlist is considered a repeating playlist if any of the songs contain a reference to a previous song in the playlist. Otherwise, the playlist will end with the last song which points to null.
	Implement a function IsRepeatingPlaylist that, efficiently with respect to time used, returns true if a playlist is repeating or false if it is not.
	For example, the following code prints "True" as both songs point to each other.
*/

namespace TestDome.Tasks
{
	/// <summary>
	/// The song.
	/// </summary>
	public class Song
	{
		private readonly string name;

		/// <summary>
		/// Gets or sets the next song.
		/// </summary>
		/// <value>
		/// The next song.
		/// </value>
		public Song NextSong { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Song"/> class.
		/// </summary>
		/// <param name="name">The name.</param>
		public Song(string name)
		{
			this.name = name;
		}

		/// <summary>
		/// Determines whether [is repeating playlist].
		/// </summary>
		/// <returns>
		///   <c>true</c> if [is repeating playlist]; otherwise, <c>false</c>.
		/// </returns>
		public bool IsRepeatingPlaylist()
		{
			Song slow = NextSong;
			Song fast = slow?.NextSong;

			while (fast != null)
			{
				if (slow == this || slow == fast)
				{
					return true;
				}

				slow = slow.NextSong;
				fast = fast.NextSong;

				if (fast != null)
				{
					fast = fast.NextSong;
				}
			}

			return false;
		}
	}
}