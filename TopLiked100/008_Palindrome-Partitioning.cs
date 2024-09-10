namespace TopLiked100
{
	public class Solution008
	{
		public IList<IList<string>> Partition(string s)
		{
			var result = new List<IList<string>>();
			var current = new List<string>();

			Backtrack(result, current, s, 0);

			return result;
		}

		private void Backtrack(IList<IList<string>> result, List<string> current, string s, int start)
		{
			if (start == s.Length)
			{
				result.Add(new List<string>(current));
				return;
			}

			for (int i = start; i < s.Length; i++)
			{
				if (IsPalindrome(s, start, i))
				{
					current.Add(s.Substring(start, i - start + 1));

					Backtrack(result, current, s, i + 1);

					current.RemoveAt(current.Count - 1);
				}
			}
		}

		private bool IsPalindrome(string s, int low, int high)
		{
			while (low < high)
			{
				if (s[low++] != s[high--])
				{
					return false;
				}
			}

			return true;
		}
	}
}
