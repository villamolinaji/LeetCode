namespace TopInterview150
{
	public class Solution019
	{
		public int LengthOfLastWord(string s)
		{
			var split = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

			if (split.Length > 0)
			{
				return split[^1].Length;
			}

			return 0;
		}
	}
}
