namespace TopInterview150
{
	public class Solution014
	{
		public int CanCompleteCircuit(int[] gas, int[] cost)
		{
			int totalTank = 0;
			int currTank = 0;
			int startingStation = 0;

			for (int i = 0; i < gas.Length; i++)
			{
				totalTank += gas[i] - cost[i];
				currTank += gas[i] - cost[i];

				if (currTank < 0)
				{
					startingStation = i + 1;
					currTank = 0;
				}
			}

			if (totalTank < 0)
			{
				return -1;
			}
			else
			{
				return startingStation;
			}
		}
	}
}
