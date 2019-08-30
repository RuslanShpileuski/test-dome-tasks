/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	5. Song

	A playlist is considered a repeating playlist if any of the songs contain a reference to a previous song in the playlist. Otherwise, the playlist will end with the last song which points to null.
	Implement a function IsRepeatingPlaylist that, efficiently with respect to time used, returns true if a playlist is repeating or false if it is not.
	For example, the following code prints "True" as both songs point to each other.
*/

using System;

public class Song
{
	private string name;
	public Song NextSong { get; set; }

	public Song(string name)
	{
		this.name = name;
	}

	public bool IsRepeatingPlaylist()
	{
		Song slow = this.NextSong;

		Song fast = (slow == null) ? null : slow.NextSong;

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