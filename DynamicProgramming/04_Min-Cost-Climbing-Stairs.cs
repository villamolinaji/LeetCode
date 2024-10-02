namespace DynamicProgramming
{
	public class Solution04
	{
		public int MinCostClimbingStairs(int[] cost)
		{
			int minCost = int.MaxValue;

			var queue = new Queue<(int, int)>();
			queue.Enqueue((0, cost[0]));
			queue.Enqueue((1, cost[1]));

			var visited = new Dictionary<int, int>();
			visited.Add(0, cost[0]);
			visited.Add(1, cost[1]);

			while (queue.Count > 0)
			{
				var (index, currentCost) = queue.Dequeue();

				if (index >= cost.Length - 2)
				{
					minCost = Math.Min(minCost, currentCost);
					continue;
				}

				for (int i = 1; i < 3; i++)
				{
					var newIndex = index + i;
					var newCost = currentCost + cost[newIndex];

					if (visited.ContainsKey(newIndex))
					{
						if (visited[newIndex] <= newCost)
						{
							continue;
						}
						else
						{
							visited[newIndex] = newCost;
						}
					}
					else
					{
						visited.Add(newIndex, newCost);
					}

					queue.Enqueue((newIndex, newCost));
				}
			}

			return minCost;
		}
	}
}
