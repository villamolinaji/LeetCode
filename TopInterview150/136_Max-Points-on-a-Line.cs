namespace TopInterview150
{
	public class Solution136
	{
		public int MaxPoints(int[][] points)
		{
			var pointsLength = points.Length;
			if (pointsLength <= 1)
			{
				return pointsLength;
			}

			int maxPoints = 1;

			for (int i = 0; i < pointsLength; i++)
			{
				var slopes = new Dictionary<string, int>();
				var overlap = 0;
				var vertical = 0;
				var localMax = 0;

				for (int j = i + 1; j < points.Length; j++)
				{
					var dx = points[j][0] - points[i][0];
					var dy = points[j][1] - points[i][1];

					if (dx == 0 && dy == 0)
					{
						overlap++;
						continue;
					}

					if (dx == 0)
					{
						vertical++;
					}
					else
					{
						var gcd = GCD(dx, dy);
						dx /= gcd;
						dy /= gcd;

						string slopeKey = dy + "/" + dx;

						if (!slopes.ContainsKey(slopeKey))
						{
							slopes[slopeKey] = 0;
						}
						slopes[slopeKey]++;

						localMax = Math.Max(localMax, slopes[slopeKey]);
					}

					localMax = Math.Max(localMax, vertical);
				}

				maxPoints = Math.Max(maxPoints, localMax + overlap + 1);
			}

			return maxPoints;
		}

		private int GCD(int a, int b)
		{
			if (b == 0)
			{
				return a;
			}

			return GCD(b, a % b);
		}
	}
}
