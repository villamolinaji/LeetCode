namespace LeetCode75
{
	public class Solution18
	{
		public int LargestAltitude(int[] gain)
		{
			int largestAltitude = 0;
			int currentAltitude = 0;

			for (int i = 0; i < gain.Length; i++)
			{
				currentAltitude = currentAltitude + gain[i];

				largestAltitude = Math.Max(largestAltitude, currentAltitude);
			}

			return largestAltitude;
		}
	}
}
