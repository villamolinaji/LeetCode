namespace TopInterview150
{
	public class Solution011
	{
		public int HIndex(int[] citations)
		{
			var hIndex = citations.Length;

			while (hIndex > 0)
			{
				var count = citations.Count(c => c >= hIndex);

				if (count >= hIndex)
				{
					break;
				}

				hIndex--;
			}

			return hIndex;
		}
	}
}
