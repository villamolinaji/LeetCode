namespace DailyChallenge
{
	public class Solution001
	{
#pragma warning disable S2368 // Public methods should not have multidimensional array parameters
		public int FindTheCity(int n, int[][] edges, int distanceThreshold)
#pragma warning restore S2368 // Public methods should not have multidimensional array parameters
		{
			int[,] nodeDistance = new int[n, n];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (i == j)
					{
						nodeDistance[i, j] = 0;
					}
					else
					{
						nodeDistance[i, j] = (int)Math.Pow(10, 5);
					}
				}
			}

			foreach (var edge in edges)
			{
				int from = edge[0];
				int to = edge[1];
				int weight = edge[2];
				nodeDistance[from, to] = weight;
				nodeDistance[to, from] = weight;
			}

			for (int k = 0; k < n; k++)
			{
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						if (nodeDistance[i, j] > nodeDistance[i, k] + nodeDistance[k, j])
						{
							nodeDistance[i, j] = nodeDistance[i, k] + nodeDistance[k, j];
						}
					}
				}
			}

			int minNeighborCount = int.MaxValue;
			int bestCity = -1;

			for (int i = 0; i < n; i++)
			{
				int neighborCount = 0;
				for (int j = 0; j < n; j++)
				{
					if (i != j &&
						nodeDistance[i, j] <= distanceThreshold)
					{
						neighborCount++;
					}
				}

				if (neighborCount <= minNeighborCount)
				{
					minNeighborCount = neighborCount;
					bestCity = i;
				}
			}

			return bestCity;
		}
	}
}
