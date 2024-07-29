namespace DailyChallenge
{
	public class Solution002
	{
		public int NumTeams(int[] rating)
		{
			int numTeams = 0;

			for (int i = 0; i < rating.Length; i++)
			{
				for (int j = i + 1; j < rating.Length; j++)
				{
					for (int k = j + 1; k < rating.Length; k++)
					{
						if ((rating[i] < rating[j] && rating[j] < rating[k]) ||
							(rating[i] > rating[j] && rating[j] > rating[k]))
						{
							numTeams++;
						}
					}
				}
			}

			return numTeams;
		}
	}
}
