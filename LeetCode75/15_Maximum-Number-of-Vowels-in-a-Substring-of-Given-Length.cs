namespace LeetCode75
{
	public class Solution15
	{
		public int MaxVowels(string s, int k)
		{
			int maxVowels = 0;

			var sAux = s.Substring(0, k);
			var vowelsCount = sAux.Count(c => "aeiou".Contains(c));
			maxVowels = Math.Max(maxVowels, vowelsCount);

			for (int i = 1; i <= s.Length - k; i++)
			{
				if ("aeiou".Contains(s[i - 1]))
				{
					vowelsCount--;
				}
				if ("aeiou".Contains(s[i + k - 1]))
				{
					vowelsCount++;
				}

				maxVowels = Math.Max(maxVowels, vowelsCount);
			}

			return maxVowels;
		}
	}
}
