namespace DailyChallenge
{
	public class Solution010
	{
		public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
		{
			var result = new List<int[]>();

			int[][] directions = new int[][] {
				[0, 1],
				[1, 0],
				[0, -1],
				[-1, 0]
			};

			int totalCells = rows * cols;
			int steps = 1;
			int directionsIndex = 0;
			int r = rStart;
			int c = cStart;


			result.Add([r, c]);

			while (result.Count < totalCells)
			{
				for (int i = 0; i < steps; i++)
				{
					r += directions[directionsIndex][0];
					c += directions[directionsIndex][1];

					if (r >= 0 &&
						r < rows &&
						c >= 0 &&
						c < cols)
					{
						result.Add([r, c]);
					}
				}

				directionsIndex = (directionsIndex + 1) % 4;

				if (directionsIndex == 0 || directionsIndex == 2)
				{
					steps++;
				}
			}

			return result.ToArray();
		}
	}
}
