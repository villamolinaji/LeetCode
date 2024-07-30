namespace DailyChallenge
{
	public class Solution003
	{
		public int MinimumDeletions(string s)
		{
			if (s.Length < 2)
			{
				return 0;
			}

			int aCounter = 0;
			int bCounter = 0;

			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == 'a')
				{
					bCounter++;
				}
			}

			int returnValue = bCounter;

			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == 'a')
				{
					bCounter--;
				}
				else
				{
					aCounter++;
				}

				returnValue = Math.Min(aCounter + bCounter, returnValue);
			}


			return returnValue;
		}
	}
}
