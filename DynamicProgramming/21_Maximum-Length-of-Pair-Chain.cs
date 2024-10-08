namespace DynamicProgramming
{
	public class Solution21
	{
		public int FindLongestChain(int[][] pairs)
		{
			Array.Sort(pairs, (a, b) => a[1].CompareTo(b[1]));

			int currentEnd = int.MinValue;
			int chainLength = 0;

			foreach (var pair in pairs)
			{
				if (pair[0] > currentEnd)
				{
					chainLength++;
					currentEnd = pair[1];
				}
			}

			return chainLength;
		}
	}
}
