namespace LeetCode75
{
	public class Solution20
	{
		public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
		{
			var list1 = nums1.ToList();
			var list2 = nums2.ToList();

			var newList1 = list1.Where(n => !list2.Contains(n)).Distinct().ToList();
			var newList2 = list2.Where(n => !list1.Contains(n)).Distinct().ToList();

			return new List<IList<int>> { newList1, newList2 };
		}
	}
}
