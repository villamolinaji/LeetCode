namespace BinarySearch
{
	public class Solution32
	{
		public int MaxEnvelopes(int[][] envelopes)
		{
			Array.Sort(envelopes, (a, b) =>
			{
				if (a[0] == b[0])
				{
					return b[1] - a[1];
				}
				else
				{
					return a[0] - b[0];
				}
			});

			var heights = new List<int>();

			foreach (var envelope in envelopes)
			{
				heights.Add(envelope[1]);
			}

			return LengthOfLIS(heights.ToArray());
		}

		private static int LengthOfLIS(int[] nums)
		{
			var lis = new List<int>();

			foreach (int num in nums)
			{
				int index = lis.BinarySearch(num);

				if (index < 0)
				{
					index = -(index + 1);
				}

				if (index >= lis.Count)
				{
					lis.Add(num);
				}
				else
				{
					lis[index] = num;
				}
			}

			return lis.Count;
		}
	}
}
