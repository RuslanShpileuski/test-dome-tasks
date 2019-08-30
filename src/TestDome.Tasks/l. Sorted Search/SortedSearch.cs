/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	12. Sorted Search

	Implement function CountNumbers that accepts a sorted array of unique integers and, efficiently with respect to time used, counts the number of array elements that are less than the parameter lessThan.
	For example, SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4) should return 2 because there are two array elements less than 4.
*/
namespace TestDome.Tasks
{
	public class SortedSearch
	{
		private int FindMid(int[] sortedArray, int left, int right, int lessThan)
		{
			int middle = left + (right - left) / 2;
			if (sortedArray[middle] == lessThan)
			{
				// If duplicates are present it returns the position of the first element
				while (middle - 1 > 0 && sortedArray[middle - 1] == lessThan)
				{
					--middle;
				}

				return middle;
			}
			if (middle <= left)
			{
				// It happens if lessThan is not present in the array
				while (middle <= right && sortedArray[middle] < lessThan)
				{
					++middle;
				}

				return middle;
			}
			if (sortedArray[middle] < lessThan)
			{
				left = middle;  // ignore left half
			}
			else
			{
				right = middle;  // ignore right half
			}

			return FindMid(sortedArray, left, right, lessThan);
		}

		public int CountNumbers(int[] sortedArray, int lessThan)
		{
			int left = 0;
			int right = sortedArray.Length - 1;
			return FindMid(sortedArray, left, right, lessThan);
		}
	}
}