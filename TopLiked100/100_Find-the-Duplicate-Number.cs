namespace TopLiked100
{
	public class Solution100
	{
		public int FindDuplicate(int[] nums)
		{
			return nums
				.GroupBy(x => x)
				.Where(x => x.Count() > 1)
				.Select(x => x.Key)
				.First();
		}
	}
}
