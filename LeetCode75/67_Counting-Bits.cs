namespace LeetCode75
{
	public class Solution67
	{
		public int[] CountBits(int n)
		{
			var result = new int[n + 1];

			for (int i = 1; i <= n; i++)
			{
				string binary = Convert.ToString(i, 2);
				result[i] = binary.Count(c => c == '1');
			}

			return result;
		}
	}
}
