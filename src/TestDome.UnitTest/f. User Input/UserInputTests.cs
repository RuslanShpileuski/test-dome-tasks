namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using TestDome.Tasks;

	[TestClass]
	public class UserInputTests
	{
		[TestMethod]
		public void TextInput_GetValue()
		{
			// Arrange.
			TextInput input = new NumericInput();
			input.Add('1');
			input.Add('a');
			input.Add('0');
			string expected = "10";

			// Act.
			string actual = input.GetValue();

			// Assert.
			Assert.AreEqual(expected, actual);
		}
	}
}