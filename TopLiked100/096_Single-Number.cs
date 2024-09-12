namespace TopLiked100
{
	public class Solution096
	{
		public int SingleNumber(int[] nums)
		{
			return nums
				.GroupBy(n => n)
				.Select(n => (n.Key, n.Count()))
				.OrderBy(n => n.Item2)
				.First()
				.Key;
		}
	}
}
