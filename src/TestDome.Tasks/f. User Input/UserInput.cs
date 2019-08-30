/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18
	
	6. User Input
	
	User interface contains two types of user input controls: TextInput, which accepts all characters and NumericInput, which accepts only digits.

	Implement the class TextInput that contains:

	Public method void Add(char c) - adds the given character to the current value
	Public method string GetValue() - returns the current value
	Implement the class NumericInput that:
		Inherits TextInput
		Overrides the Add method so that each non-numeric character is ignored

	<example>
	For example, the following code should output "10":
	<code>
		TextInput input = new NumericInput();
		input.Add('1');
		input.Add('a');
		input.Add('0');
		Console.WriteLine(input.GetValue());
	</code>
	</example>
*/

namespace TestDome.Tasks
{
	using System.Text;

	/// <summary>
	/// The text input.
	/// </summary>
	public class TextInput
	{
		/// <summary>
		/// The builder.
		/// </summary>
		protected StringBuilder builder = new StringBuilder();

		/// <summary>
		/// Adds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		public virtual void Add(char value)
		{
			builder.Append(value);
		}

		/// <summary>
		/// Gets the value.
		/// </summary>
		/// <returns>The value.</returns>
		public string GetValue()
		{
			return builder.ToString();
		}
	}

	/// <summary>
	/// The numeric input.
	/// </summary>
	/// <seealso cref="TestDome.Tasks.TextInput" />
	public class NumericInput : TextInput
	{
		/// <summary>
		/// Adds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		public override void Add(char value)
		{
			if (char.IsDigit(value))
			{
				builder.Append(value);
			}
		}
	}
}