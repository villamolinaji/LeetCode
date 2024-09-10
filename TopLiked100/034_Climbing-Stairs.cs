namespace TopLiked100
{
	public class Solution034
	{
		public int ClimbStairs(int n)
		{
			if (n <= 2)
			{
				return n;
			}

			int first = 1;
			int second = 2;
			for (int i = 3; i <= n; i++)
			{
				int third = first + second;
				first = second;
				second = third;
			}

			return second;
		}
	}
}
