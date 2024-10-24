﻿namespace BinarySearch
{
	public class Solution22
	{
		public int SingleNonDuplicate(int[] nums)
		{
			int left = 0;
			int right = nums.Length - 1;

			while (left < right)
			{
				int mid = left + (right - left) / 2;

				if (mid % 2 == 1)
				{
					mid--;
				}

				if (nums[mid] == nums[mid + 1])
				{
					left = mid + 2;
				}
				else
				{
					right = mid;
				}
			}

			return nums[left];
		}
	}
}
