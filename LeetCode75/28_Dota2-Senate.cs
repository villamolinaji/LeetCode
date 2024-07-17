namespace LeetCode75
{
	public class Solution28
	{
		public string PredictPartyVictory(string senate)
		{
			int index = 0;
			while (senate.Length > 1)
			{
				var currentVote = senate[index];				

				if (currentVote == 'R')
				{
					var indexOfD = senate.IndexOf('D', index);
					if (indexOfD == -1)
					{
						indexOfD = senate.IndexOf('D');
						if (indexOfD == -1)
						{
							return "Radiant";
						}
						senate = senate.Remove(indexOfD, 1);
						index--;
					}
					else
					{
						senate = senate.Remove(indexOfD, 1);						
					}
				}
				else
				{
					var indexOfR = senate.IndexOf('R', index);
					if (indexOfR == -1)
					{
						indexOfR = senate.IndexOf('R');
						if (indexOfR == -1)
						{
							return "Dire";
						}
						senate = senate.Remove(indexOfR, 1);
						index--;
					}
					else
					{
						senate = senate.Remove(indexOfR, 1);						
					}
				}

				index++;
				if (index >= senate.Length)
				{
					index = 0;
				}
			}

			return senate == "R" 
				? "Radiant" 
				: "Dire";
		}
	}
}
