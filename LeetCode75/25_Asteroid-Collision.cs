namespace LeetCode75
{
	public class Solution25
	{
		public int[] AsteroidCollision(int[] asteroids)
		{
			var right = new List<int>();
			var left = new List<int>();

			var result = new List<int>();

			for (int i = 0; i < asteroids.Length; i++)
			{
				if (asteroids[i] < 0)
				{					
					if (right.Count > 0)
					{
						left.Add(asteroids[i]);

						while (left.Count > 0 && right.Count > 0)
						{
							var lastLeft = Math.Abs(left[left.Count - 1]);
							var lastRight = Math.Abs(right[right.Count - 1]);
							if (lastLeft > lastRight)
							{
								right.RemoveAt(right.Count - 1);
							}
							else if (lastLeft < lastRight)
							{
								left.RemoveAt(left.Count - 1);
							}
							else
							{
								left.RemoveAt(left.Count - 1);
								right.RemoveAt(right.Count - 1);
							}
						}

						if (left.Count > 0)
						{
							result = result.Concat(left).ToList();
							left.Clear();
						}
					}
					else
					{
						if (left.Any())
						{
							left.Add(asteroids[i]);
						}
						else
						{
							result.Add(asteroids[i]);
						}
					}
				}
				else
				{
					right.Add(asteroids[i]);
				}
			}	

			if (left.Count > 0)
			{
				result = result.Concat(left).ToList();
			}
			if (right.Count > 0)
			{
				result = result.Concat(right).ToList();
			}

			return result.ToArray();
		}
	}
}
