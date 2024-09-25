namespace ProgrammingSkills
{
	public class Solution18
	{
		public int MaximumWealth(int[][] accounts)
		{
			int maxWealth = 0;

			foreach (var account in accounts)
			{
				int wealth = account.Sum();

				if (wealth > maxWealth)
				{
					maxWealth = wealth;
				}
			}

			return maxWealth;
		}
	}
}
