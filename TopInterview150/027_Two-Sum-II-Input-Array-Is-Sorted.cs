namespace TopInterview150
{
	public class Solution027
	{
		public int[] TwoSum(int[] numbers, int target)
		{
			var numbersLength = numbers.Length;

			for (int i = 0; i < numbersLength - 1; i++)
			{
				for (int j = i + 1; j < numbers.Length; j++)
				{
					var sum = numbers[i] + numbers[j];

					if (sum == target)
					{
						return new int[] { i + 1, j + 1 };
					}
					else if (sum > target)
					{
						break;
					}
				}
			}

			return new int[0];
		}
	}
}
