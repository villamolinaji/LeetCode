﻿namespace TopInterview150
{
	public class Solution016
	{
		public int Trap(int[] height)
		{
			int left = 0;
			int right = height.Length - 1;
			int leftMax = 0;
			int rightMax = 0;
			int waterTrapped = 0;

			while (left < right)
			{
				if (height[left] < height[right])
				{
					if (height[left] >= leftMax)
					{
						leftMax = height[left];
					}
					else
					{
						waterTrapped += leftMax - height[left];
					}

					left++;
				}
				else
				{
					if (height[right] >= rightMax)
					{
						rightMax = height[right];
					}
					else
					{
						waterTrapped += rightMax - height[right];
					}

					right--;
				}
			}

			return waterTrapped;
		}
	}
}