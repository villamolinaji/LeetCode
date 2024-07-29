namespace TopInterview150
{
	public class Solution005
	{
		public int MajorityElement(int[] nums)
		{
			return nums
				.GroupBy(x => x)
				.Select(x => (x.Key, x.Count()))
				.OrderByDescending(x => x.Item2)
				.First().Key;
		}
	}
}
