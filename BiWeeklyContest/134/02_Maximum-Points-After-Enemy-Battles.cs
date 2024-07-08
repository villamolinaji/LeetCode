namespace _134
{
	public class Solution02
	{
		public long MaximumPoints(int[] enemyEnergies, int currentEnergy)
		{
			Array.Sort(enemyEnergies);
			int end = enemyEnergies.Length - 1;
			long points = 0;

			if (currentEnergy < enemyEnergies[0])
			{
				return 0;
			}

			while (end >= 0)
			{
				if (currentEnergy >= enemyEnergies[0])
				{
					points += currentEnergy / enemyEnergies[0];
					currentEnergy = currentEnergy % enemyEnergies[0];
				}
				currentEnergy += enemyEnergies[end];
				end--;
			}
			return points;
		}
	}
}
