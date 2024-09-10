namespace TopLiked100
{
	public class Solution037
	{
		public bool WordBreak(string s, IList<string> wordDict)
		{
			var wordSet = new HashSet<string>(wordDict);
			var sLength = s.Length;
			var dp = new bool[sLength + 1];
			dp[0] = true;

			for (int i = 1; i <= sLength; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (dp[j] &&
						wordSet.Contains(s.Substring(j, i - j)))
					{
						dp[i] = true;
						break;
					}
				}
			}

			return dp[sLength];
		}
	}
}
