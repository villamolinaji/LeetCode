namespace DailyChallenge
{
	public class Solution015
	{
		public int MaxDistance(IList<IList<int>> arrays)
		{
			var maxDistance = 0;
			var min = arrays[0][0];
			var max = arrays[0][^1];

			for (int i = 1; i < arrays.Count; i++)
			{
				int currentMin = arrays[i][0];
				int currentMax = arrays[i][^1];

				maxDistance = Math.Max(maxDistance, Math.Max(Math.Abs(currentMax - min), Math.Abs(max - currentMin)));

				min = Math.Min(min, currentMin);
				max = Math.Max(max, currentMax);
			}

			return maxDistance;
		}
	}
}
