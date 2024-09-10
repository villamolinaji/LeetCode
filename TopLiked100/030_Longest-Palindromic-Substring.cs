namespace TopLiked100
{
	public class Solution030
	{
		public string LongestPalindrome(string s)
		{
			var sLength = s.Length;
			if (sLength == 0)
			{
				return "";
			}

			var dp = new bool[sLength, sLength];
			var maxLength = 1;
			var start = 0;

			for (int i = 0; i < sLength; i++)
			{
				dp[i, i] = true;
			}

			for (int i = 0; i < sLength - 1; i++)
			{
				if (s[i] == s[i + 1])
				{
					dp[i, i + 1] = true;
					start = i;
					maxLength = 2;
				}
			}

			for (int len = 3; len <= sLength; len++)
			{
				for (int i = 0; i < sLength - len + 1; i++)
				{
					int j = i + len - 1;

					if (dp[i + 1, j - 1] &&
						s[i] == s[j])
					{
						dp[i, j] = true;

						if (len > maxLength)
						{
							start = i;
							maxLength = len;
						}
					}
				}
			}

			return s.Substring(start, maxLength);
		}
	}
}
