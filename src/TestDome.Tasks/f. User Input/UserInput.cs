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

using System;
using System.Text;

public class TextInput
{
	protected StringBuilder builder = new StringBuilder();

	public virtual void Add(char c)
	{
		builder.Append(c);
	}

	public string GetValue()
	{
		return this.builder.ToString();
	}
}

public class NumericInput : TextInput
{
	public override void Add(char c)
	{
		if (Char.IsDigit(c))
		{
			this.builder.Append(c);
		}
	}
}