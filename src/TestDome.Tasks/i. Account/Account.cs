/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	9. Account

	Each account on a website has a set of access flags that represent a users access.

	Update and extend the enum so that it contains three new access flags:

		A Writer access flag that is made up of the Submit and Modify flags.
		An Editor access flag that is made up of the Delete, Publish and Comment flags.
		An Owner access that is made up of the Writer and Editor flags.

	<example>
	For example, the code below should print "False" as the Writer flag does not contain the Delete flag.
	<code>
		Console.WriteLine(Access.Writer.HasFlag(Access.Delete))
	</code>
	</example>
*/

namespace TestDome.Tasks.Flags
{
	using System;

	/// <summary>
	/// The account.
	/// </summary>
	public class Account
	{
		/// <summary>
		/// The access enum.
		/// </summary>
		[Flags]
		public enum Access
		{
			/// <summary>
			/// The none.
			/// </summary>
			None = 0,

			/// <summary>
			/// The delete.
			/// </summary>
			Delete = 1 << 0,

			/// <summary>
			/// The publish.
			/// </summary>
			Publish = 1 << 1,

			/// <summary>
			/// The submit.
			/// </summary>
			Submit = 1 << 2,

			/// <summary>
			/// The comment.
			/// </summary>
			Comment = 1 << 3,

			/// <summary>
			/// The modify.
			/// </summary>
			Modify = 1 << 4,

			/// <summary>
			/// The writer.
			/// </summary>
			Writer = Submit | Modify,

			/// <summary>
			/// The editor.
			/// </summary>
			Editor = Delete | Publish | Comment,

			/// <summary>
			/// The owner.
			/// </summary>
			Owner = Writer | Editor
		}
	}
}