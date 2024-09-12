namespace TopLiked100
{
	public class Solution080
	{
		public IList<int> FindAnagrams(string s, string p)
		{
			var result = new List<int>();
			var pFreq = new int[26];
			var sFreq = new int[26];

			if (s.Length < p.Length)
			{
				return result;
			}

			for (int i = 0; i < p.Length; i++)
			{
				pFreq[p[i] - 'a']++;
				sFreq[s[i] - 'a']++;
			}

			for (int i = 0; i < s.Length - p.Length; i++)
			{
				if (IsAnagram(pFreq, sFreq))
				{
					result.Add(i);
				}

				sFreq[s[i] - 'a']--;
				sFreq[s[i + p.Length] - 'a']++;
			}

			if (IsAnagram(pFreq, sFreq))
			{
				result.Add(s.Length - p.Length);
			}

			return result;
		}

		private bool IsAnagram(int[] pFreq, int[] sFreq)
		{
			for (int i = 0; i < 26; i++)
			{
				if (pFreq[i] != sFreq[i])
				{
					return false;
				}
			}

			return true;
		}
	}
}
