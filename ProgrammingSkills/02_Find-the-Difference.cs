namespace ProgrammingSkills
{
	public class Solution02
	{
		public char FindTheDifference(string s, string t)
		{
			var sOrdered = s.OrderBy(c => c).ToList();
			var tOrdered = t.OrderBy(c => c).ToList();

			var indexS = 0;
			foreach (var sChar in sOrdered)
			{
				if (tOrdered[indexS] != sChar)
				{
					return tOrdered[indexS];
				}

				indexS++;
			}

			return tOrdered[t.Length - 1];
		}
	}
}
