namespace LeetCode75
{
	public class Solution11
	{
		public bool IsSubsequence(string s, string t)
		{
			var tRemoved = string.Join("", t.Where(c => s.Contains(c)));

			var isSubsequence = false;

			int indexRemoved = 0;
			int indexS = 0;
			while (indexRemoved < tRemoved.Length && indexS < s.Length)
			{
				if (tRemoved[indexRemoved] == s[indexS])
				{
					indexS++;
				}
				indexRemoved++;
			}

			if (indexS == s.Length)
			{
				isSubsequence = true;
			}

			return isSubsequence;
		}
	}
}
