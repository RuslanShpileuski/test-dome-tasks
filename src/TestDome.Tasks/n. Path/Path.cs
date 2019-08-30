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

	/// <summary>
	/// The path.
	/// </summary>
	public class Path
	{
		/// <summary>
		/// Gets the current path.
		/// </summary>
		/// <value>
		/// The current path.
		/// </value>
		public string CurrentPath { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Path"/> class.
		/// </summary>
		/// <param name="path">The path.</param>
		public Path(string path)
		{
			CurrentPath = path;
		}

		/// <summary>
		/// Cds the specified new path.
		/// </summary>
		/// <param name="newPath">The new path.</param>
		/// <exception cref="NotImplementedException">Waiting to be implemented.</exception>
		public void Cd(string newPath)
		{
			throw new NotImplementedException("Waiting to be implemented.");
		}

		/// <summary>
		/// Tests the specified arguments.
		/// </summary>
		/// <param name="args">The arguments.</param>
		public void Test(string[] args)
		{
			Path path = new Path("/a/b/c/d");
			path.Cd("../x");
			Console.WriteLine(path.CurrentPath);
		}
	}
}