namespace DailyChallenge
{
	public class Solution008
	{
		public int MinimumPushes(string word)
		{
			var pushes = 0;
			var countChars = 0;
			var pushsChar = 0;
			var wordChars = word
				.GroupBy(w => w)
				.Select(g => new { Letter = g.Key, Count = g.Count() })
				.OrderByDescending(w => w.Count);

			foreach (var wc in wordChars)
			{
				countChars++;
				if (countChars < 9)
				{
					pushsChar = 1;
				}
				else if (countChars < 17)
				{
					pushsChar = 2;
				}
				else if (countChars < 25)
				{
					pushsChar = 3;
				}
				else
				{
					pushsChar = 4;
				}

				pushes = pushes + (wc.Count * pushsChar);
			}

			return pushes;
		}
	}
}
