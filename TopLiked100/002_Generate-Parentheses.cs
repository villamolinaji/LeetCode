namespace TopLiked100
{
	public class Solution002
	{
		public IList<string> GenerateParenthesis(int n)
		{
			var result = new List<string>();

			Backtrack(result, "", 0, 0, n);

			return result;
		}

		private void Backtrack(IList<string> result, string current, int open, int close, int n)
		{
			if (current.Length == n * 2)
			{
				result.Add(current);

				return;
			}

			if (open < n)
			{
				Backtrack(result, current + "(", open + 1, close, n);
			}

			if (close < open)
			{
				Backtrack(result, current + ")", open, close + 1, n);
			}
		}
	}
}
