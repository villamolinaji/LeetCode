namespace TopLiked100
{
	public class Solution074
	{
		public IList<int> SpiralOrder(int[][] matrix)
		{
			var result = new List<int>();
			var rowLength = matrix.Length;
			var colLength = matrix[0].Length;
			var length = rowLength * colLength;
			var visited = new HashSet<(int, int)>();
			var indexRow = 0;
			var indexCol = 0;
			var direction = 1;

			for (int i = 0; i < length; i++)
			{
				var digit = matrix[indexRow][indexCol];

				result.Add(digit);

				visited.Add((indexRow, indexCol));

				switch (direction)
				{
					case 1:
						if (indexCol + 1 < colLength)
						{
							if (!visited.Contains((indexRow, indexCol + 1)))
							{
								indexCol++;
							}
							else
							{
								if (!visited.Contains((indexRow + 1, indexCol)))
								{
									indexRow++;
									direction = 2;
								}
								else
								{
									indexCol--;
									direction = 3;
								}
							}
						}
						else
						{
							indexRow++;
							direction = 2;
						}
						break;
					case 2:
						if (indexRow + 1 < rowLength)
						{
							if (!visited.Contains((indexRow + 1, indexCol)))
							{
								indexRow++;
							}
							else
							{
								if (!visited.Contains((indexRow, indexCol - 1)))
								{
									indexCol--;
									direction = 3;
								}
								else
								{
									indexRow--;
									direction = 4;
								}
							}
						}
						else
						{
							indexCol--;
							direction = 3;
						}
						break;
					case 3:
						if (indexCol - 1 >= 0)
						{
							if (!visited.Contains((indexRow, indexCol - 1)))
							{
								indexCol--;
							}
							else
							{
								if (!visited.Contains((indexRow - 1, indexCol)))
								{
									indexRow--;
									direction = 4;
								}
								else
								{
									indexCol++;
									direction = 1;
								}
							}
						}
						else
						{
							indexRow--;
							direction = 4;
						}
						break;
					default:
						if (indexRow - 1 >= 0)
						{
							if (!visited.Contains((indexRow - 1, indexCol)))
							{
								indexRow--;
							}
							else
							{
								if (!visited.Contains((indexRow, indexCol + 1)))
								{
									indexCol++;
									direction = 1;
								}
								else
								{
									indexRow++;
									direction = 2;
								}
							}
						}
						else
						{
							indexCol++;
							direction = 1;
						}
						break;
				}
			}

			return result;
		}
	}
}
