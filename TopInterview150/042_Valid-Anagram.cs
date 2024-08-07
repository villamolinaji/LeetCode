namespace TopInterview150
{
	public class Solution042
	{
		public bool IsAnagram(string s, string t)
		{
			if (s.Length != t.Length)
			{
				return false;
			}

			var charGroupS = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
			var charGroupT = t.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

			if (charGroupS.Count != charGroupT.Count)
			{
				return false;
			}

			foreach (var (key, value) in charGroupS)
			{
				if (!charGroupT.ContainsKey(key) ||
					charGroupT[key] != value)
				{
					return false;
				}
			}

			return true;
		}
	}
}
