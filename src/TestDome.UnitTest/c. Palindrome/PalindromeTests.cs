namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using TestDome.Tasks;

	[TestClass]
	public class PalindromeTests
	{
		[TestMethod]
		public void Palindrome_IsPalindorme_VariousCases()
		{
			// Arrange.
			Palindrome palindrome = new Palindrome();

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