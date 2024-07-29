namespace TopInterview150
{
	public class Solution001
	{
		public void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			var indexM = 0;
			var indexN = 0;

			for (int i = 0; i < nums1.Length; i++)
			{
				int valueN = int.MaxValue;
				if (indexN < n)
				{
					valueN = nums2[indexN];
				}
				if (indexM < m)
				{
					if (nums1[i] <= valueN)
					{
						indexM++;
					}
					else
					{
						for (int j = nums1.Length - 1; j > i; j--)
						{
							nums1[j] = nums1[j - 1];
						}

						nums1[i] = valueN;

						indexN++;
					}
				}
				else
				{
					nums1[i] = valueN;
					indexN++;
				}
			}
		}
	}
}
