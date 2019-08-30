/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	14. Path

	Write a function that provides change directory (cd) function for an abstract file system.

	Notes:

		Root path is '/'.
		Path separator is '/'.
		Parent directory is addressable as "..".
		Directory names consist only of English alphabet letters (A-Z and a-z).
		The function should support both relative and absolute paths.
		The function will not be passed any invalid paths.
		Do not use built-in path-related functions.

	<example>
		For example, the following code should display '/a/b/c/x'.
	<code>
		Path path = new Path("/a/b/c/d");
		path.Cd("../x");
		Console.WriteLine(path.CurrentPath);
	</code>
	</example>
*/

namespace TestDome.Tasks
{
	using System;

	public class Path
	{
		public string CurrentPath { get; private set; }

		public Path(string path)
		{
			this.CurrentPath = path;
		}

		public void Cd(string newPath)
		{
			throw new NotImplementedException("Waiting to be implemented.");
		}

		public void Test(string[] args)
		{
			Path path = new Path("/a/b/c/d");
			path.Cd("../x");
			Console.WriteLine(path.CurrentPath);
		}
	}
}