namespace TopInterview150
{
	public class Solution048
	{
		public IList<string> SummaryRanges(int[] nums)
		{
			var result = new List<string>();

			if (nums.Length > 0)
			{
				int previous = nums[0];
				var currentCover = new List<int> { previous };

				for (int i = 1; i < nums.Length; i++)
				{
					if (nums[i] == previous + 1)
					{
						currentCover.Add(nums[i]);
					}
					else if (nums[i] != previous)
					{
						if (currentCover.Count > 1)
						{
							result.Add($"{currentCover[0]}->{currentCover[^1]}");
						}
						else
						{
							result.Add(currentCover[0].ToString());
						}

						currentCover.Clear();
						currentCover.Add(nums[i]);
					}

					previous = nums[i];
				}

				if (currentCover.Count > 1)
				{
					result.Add($"{currentCover[0]}->{currentCover[^1]}");
				}
				else
				{
					result.Add(currentCover[0].ToString());
				}
			}

			return result;
		}
	}
}
