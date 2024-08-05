namespace DailyChallenge
{
	public class Solution007
	{
		public string KthDistinct(string[] arr, int k)
		{
			var distincts = arr.GroupBy(x => x)
				.Where(x => x.Count() == 1)
				.Select(x => x.Key)
				.ToList();

			if (distincts.Count < k)
			{
				return string.Empty;
			}

			return distincts.Take(k).Last();
		}
	}
}
