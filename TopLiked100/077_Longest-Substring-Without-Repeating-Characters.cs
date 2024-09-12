namespace TopLiked100
{
	public class Solution077
	{
		public int LengthOfLongestSubstring(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return 0;
			}

			int max = 1;

			for (int i = 0; i < s.Length - 1; i++)
			{
				int count = 1;
				for (int j = i + 1; j < s.Length; j++)
				{
					if (s[i..j].Contains(s[j]))
					{
						break;
					}

					count++;
				}

				if (count > max)
				{
					max = count;
				}
			}

			return max;
		}
	}
}
