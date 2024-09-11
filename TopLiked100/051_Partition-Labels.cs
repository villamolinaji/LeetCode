namespace TopLiked100
{
	public class Solution051
	{
		public IList<int> PartitionLabels(string s)
		{
			List<int> result = new List<int>();
			int[] lastIndex = new int[26];

			for (int i = 0; i < s.Length; i++)
			{
				lastIndex[s[i] - 'a'] = i;
			}

			int start = 0;
			int end = 0;

			for (int i = 0; i < s.Length; i++)
			{
				end = Math.Max(end, lastIndex[s[i] - 'a']);

				if (i == end)
				{
					result.Add(end - start + 1);

					start = i + 1;
				}
			}

			return result;
		}
	}
}
