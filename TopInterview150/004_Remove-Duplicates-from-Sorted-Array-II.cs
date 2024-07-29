namespace TopInterview150
{
	public class Solution004
	{
		public int RemoveDuplicates(int[] nums)
		{
			int k = nums.Length;
			int nLength = nums.Length;
			int index = 0;

			var numsDictionary = new Dictionary<int, int>();

			while (index < nLength)
			{
				if (numsDictionary.ContainsKey(nums[index]))
				{
					if (numsDictionary[nums[index]] == 2)
					{
						for (int j = index; j < nums.Length - 1; j++)
						{
							nums[j] = nums[j + 1];
						}

						k--;

						nLength--;
					}
					else
					{
						numsDictionary[nums[index]]++;
						index++;
					}
				}
				else
				{
					numsDictionary.Add(nums[index], 1);
					index++;
				}
			}

			return k;
		}
	}
}
