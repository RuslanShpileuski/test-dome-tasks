/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	3. Palindrome

	A palindrome is a word that reads the same backward or forward.
	Write a function that checks if a given word is a palindrome. Character case should be ignored.
	For example, IsPalindrome("Deleveled") should return true as character case should be ignored, resulting in "deleveled", which is a palindrome since it reads the same backward and forward.
*/

namespace TestDome.Tasks
{
	/// <summary>
	/// The palindrome class.
	/// </summary>
	public class Palindrome
	{
		/// <summary>
		/// Determines whether the specified word is palindrome.
		/// </summary>
		/// <param name="word">The word.</param>
		/// <returns>
		///   <c>true</c> if the specified word is palindrome; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPalindrome(string word)
		{
			int min = 0;
			int max = word.Length - 1;

			while (true)
			{
				if (min > max)
				{
					return true;
				}

				char left = word[min];
				char right = word[max];

				if (char.ToLower(left) != char.ToLower(right))
				{
					return false;
				}

				min++;
				max--;
			}
		}
	}
}