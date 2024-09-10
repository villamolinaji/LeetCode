namespace TopLiked100
{
	public class Solution009
	{
		public double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			var numsConcat = nums1.Concat(nums2).ToArray();

			Array.Sort(numsConcat);

			if (numsConcat.Length % 2 == 0)
			{
				return (numsConcat[numsConcat.Length / 2] + numsConcat[numsConcat.Length / 2 - 1]) / 2.0;
			}
			else
			{
				return numsConcat[numsConcat.Length / 2];
			}
		}
	}
}
