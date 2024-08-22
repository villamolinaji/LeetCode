namespace TopInterview150
{
	public class Solution129
	{
		public int SingleNumber(int[] nums)
		{
			var numsGrouped = nums
				.GroupBy(n => n)
				.Select(n => (n.Key, n.Count()))
				.OrderBy(n => n.Item2)
				.ToList();

			return numsGrouped[0].Key;
		}
	}
}
