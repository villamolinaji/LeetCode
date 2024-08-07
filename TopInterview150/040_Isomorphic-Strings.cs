namespace TopInterview150
{
	public class Solution040
	{
		public bool IsIsomorphic(string s, string t)
		{
			if (s.Length != t.Length)
			{
				return false;
			}

			if (s.Distinct().Count() != t.Distinct().Count())
			{
				return false;
			}

			var pairs = new Dictionary<char, char>();

			for (int i = 0; i < t.Length; i++)
			{
				if (!pairs.ContainsKey(s[i]))
				{
					pairs.Add(s[i], t[i]);
				}
				else if (pairs[s[i]] != t[i])
				{
					return false;
				}
			}

			return true;
		}
	}
}
