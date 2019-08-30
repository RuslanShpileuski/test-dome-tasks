namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class PalindromeTests
	{
		[TestMethod]
		public void Palindrome_IsPalindorme_VariousCases()
		{
			// Arrange.
			var palindrome = new Palindrome();

			// Act.
			bool firstActual = palindrome.IsPalindrome("Deleveled");
			bool secondActual = palindrome.IsPalindrome("loL");
			bool thirdActual = palindrome.IsPalindrome("Test");

			// Assert.
			Assert.IsTrue(firstActual);
			Assert.IsTrue(secondActual);
			Assert.IsFalse(thirdActual);
		}
	}
}