/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	3. Palindrome

	A palindrome is a word that reads the same backward or forward.
	Write a function that checks if a given word is a palindrome. Character case should be ignored.
	For example, IsPalindrome("Deleveled") should return true as character case should be ignored, resulting in "deleveled", which is a palindrome since it reads the same backward and forward.
*/

public class Palindrome
{
	public bool IsPalindrome(string word)
	{
		int ln = word.Length;

		for (int i = 0; i < ln / 2; i++)
		{
			if (char.ToLower(word[i]) != char.ToLower(word[ln - i - 1]))
			{
				return false;
			}
		}

		return true;
	}
}