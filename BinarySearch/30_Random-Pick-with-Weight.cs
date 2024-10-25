namespace BinarySearch
{
	public class Solution
	{
		private int[] prefixSums { get; set; }
		private int totalSum { get; set; }
		private Random random { get; set; }

		public Solution(int[] w)
		{
			int wLength = w.Length;
			prefixSums = new int[wLength];
			random = new Random();

			prefixSums[0] = w[0];
			for (int i = 1; i < wLength; i++)
			{
				prefixSums[i] = prefixSums[i - 1] + w[i];
			}

			totalSum = prefixSums[wLength - 1];
		}

		public int PickIndex()
		{
			int target = random.Next(1, totalSum + 1);

			int left = 0;
			int right = prefixSums.Length - 1;

			while (left < right)
			{
				int mid = left + (right - left) / 2;

				if (target > prefixSums[mid])
				{
					left = mid + 1;
				}
				else
				{
					right = mid;
				}
			}

			return left;
		}
	}
}
