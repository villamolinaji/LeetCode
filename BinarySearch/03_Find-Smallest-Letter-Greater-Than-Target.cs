namespace BinarySearch
{
	public class Solution03
	{
		public char NextGreatestLetter(char[] letters, char target)
		{
			//for (int i = 0; i < letters.Length; i++)
			//{
			//	if (letters[i] > target)
			//	{
			//		return letters[i];
			//	}
			//}

			//return letters[0];

			int low = 0;
			int high = letters.Length - 1;

			if (letters[high] <= target)
			{
				return letters[0];
			}

			while (low < high)
			{
				int mid = low + (high - low) / 2;

				if (letters[mid] > target)
				{
					high = mid;
				}
				else
				{
					low = mid + 1;
				}
			}

			return letters[low];
		}
	}
}
