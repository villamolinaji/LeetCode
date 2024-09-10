﻿namespace TopLiked100
{
	public class Solution012
	{
		public int SearchInsert(int[] nums, int target)
		{
			var left = 0;
			var right = nums.Length - 1;

			while (left <= right)
			{
				var mid = left + (right - left) / 2;

				if (nums[mid] == target)
				{
					return mid;
				}
				else if (nums[mid] < target)
				{
					left = mid + 1;
				}
				else
				{
					right = mid - 1;
				}
			}

			return left;
		}
	}
}
