﻿namespace TopInterview150
{
	public class Solution130
	{
		public int RangeBitwiseAnd(int left, int right)
		{
			int shift = 0;

			while (left < right)
			{
				left >>= 1;
				right >>= 1;
				shift++;
			}

			return left << shift;
		}
	}
}
