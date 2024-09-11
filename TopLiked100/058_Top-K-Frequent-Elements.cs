namespace TopLiked100
{
	public class Solution058
	{
		public int[] TopKFrequent(int[] nums, int k)
		{
			var numGroup = nums
				.GroupBy(x => x)
				.Select(x => (x.Key, x.Count()));

			return numGroup
				.OrderByDescending(x => x.Item2)
				.Take(k)
				.Select(x => x.Key)
				.ToArray();
		}
	}
}
