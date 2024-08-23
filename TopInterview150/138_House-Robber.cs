namespace TopInterview150
{
	public class Solution138
	{
		public int Rob(int[] nums)
		{
			int maxRob = 0;

			var queue = new Queue<(int, int)>();
			var visited = new Dictionary<int, int>();
			queue.Enqueue((0, nums[0]));
			visited.Add(0, nums[0]);

			if (nums.Length > 1)
			{
				queue.Enqueue((1, nums[1]));
				visited.Add(1, nums[1]);
			}

			while (queue.Count > 0)
			{
				var (index, currentRob) = queue.Dequeue();

				if (index >= nums.Length - 2)
				{
					maxRob = Math.Max(maxRob, currentRob);
					continue;
				}

				for (int i = 2; i < 4; i++)
				{
					var newIndex = index + i;
					if (newIndex < nums.Length)
					{
						var newRob = currentRob + nums[newIndex];

						if (visited.ContainsKey(newIndex))
						{
							if (visited[newIndex] >= newRob)
							{
								continue;
							}
							else
							{
								visited[newIndex] = newRob;
							}
						}
						else
						{
							visited.Add(newIndex, newRob);
						}

						queue.Enqueue((newIndex, newRob));
					}
				}
			}

			return maxRob;
		}
	}
}
