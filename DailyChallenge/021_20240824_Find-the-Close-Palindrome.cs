namespace DailyChallenge
{
	public class Solution021
	{
		public string NearestPalindromic(string n)
		{
			long longN = long.Parse(n);
			var nLength = n.Length;

			if (longN == 11)
			{
				return "9";
			}

			if (longN <= 10)
			{
				return (longN - 1).ToString();
			}

			if (longN == Math.Pow(10, nLength - 1) + 1)
			{
				return (longN - 2).ToString();
			}

			var candidates = new List<long>();
			candidates.Add((long)Math.Pow(10, nLength) + 1);
			candidates.Add((long)Math.Pow(10, nLength - 1) - 1);

			long prefix = long.Parse(n.Substring(0, (nLength + 1) / 2));

			foreach (long i in new long[] { prefix - 1, prefix, prefix + 1 })
			{
				string pal = i.ToString() + new string(i.ToString().Reverse().Skip(nLength % 2).ToArray());
				candidates.Add(long.Parse(pal));
			}

			long closestPalindrome = -1;
			foreach (long candidate in candidates)
			{
				if (candidate == longN)
				{
					continue;
				}

				if (closestPalindrome == -1 ||
					Math.Abs(candidate - longN) < Math.Abs(closestPalindrome - longN) ||
					(Math.Abs(candidate - longN) == Math.Abs(closestPalindrome - longN) && candidate < closestPalindrome))
				{
					closestPalindrome = candidate;
				}
			}

			return closestPalindrome.ToString();
		}
	}
}
