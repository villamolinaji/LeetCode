namespace TopInterview150
{
	public class Solution041
	{
		public bool WordPattern(string pattern, string s)
		{
			var sSplit = s.Split(' ');

			if (pattern.Length != sSplit.Length)
			{
				return false;
			}

			var pairs = new Dictionary<char, string>();

			for (int i = 0; i < pattern.Length; i++)
			{
				if (!pairs.ContainsKey(pattern[i]))
				{
					if (pairs.Any(p => p.Value == sSplit[i]))
					{
						return false;
					}

					pairs.Add(pattern[i], sSplit[i]);
				}
				else if (pairs[pattern[i]] != sSplit[i])
				{
					return false;
				}
			}

			return true;
		}
	}
}
