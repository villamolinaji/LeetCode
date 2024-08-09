namespace DailyChallenge
{
	public class Solution011
	{
		public int NumMagicSquaresInside(int[][] grid)
		{
			var numMagicSquares = 0;
			var rows = grid.Length;
			var cols = grid[0].Length;

			for (int i = 0; i < rows - 2; i++)
			{
				for (int j = 0; j < cols - 2; j++)
				{
					var lines = new List<List<int>>();
					lines.Add(new List<int> { grid[i][j], grid[i][j + 1], grid[i][j + 2] });
					lines.Add(new List<int> { grid[i + 1][j], grid[i + 1][j + 1], grid[i + 1][j + 2] });
					lines.Add(new List<int> { grid[i + 2][j], grid[i + 2][j + 1], grid[i + 2][j + 2] });
					lines.Add(new List<int> { grid[i][j], grid[i + 1][j], grid[i + 2][j] });
					lines.Add(new List<int> { grid[i][j + 1], grid[i + 1][j + 1], grid[i + 2][j + 1] });
					lines.Add(new List<int> { grid[i][j + 2], grid[i + 1][j + 2], grid[i + 2][j + 2] });
					lines.Add(new List<int> { grid[i][j], grid[i + 1][j + 1], grid[i + 2][j + 2] });
					lines.Add(new List<int> { grid[i][j + 2], grid[i + 1][j + 1], grid[i + 2][j] });

					var isMagicSquare = true;
					var sum = lines[0].Sum();
					var lineNumbers = new List<int>();
					lines.ForEach(x => lineNumbers.AddRange(x));

					if (lineNumbers.Distinct().Count() != 9)
					{
						isMagicSquare = false;
					}
					else
					{
						foreach (var line in lines)
						{
							if (line.Exists(x => x < 1 || x > 9) ||
								line.Sum() != sum)
							{
								isMagicSquare = false;
								break;
							}
						}
					}

					if (isMagicSquare)
					{
						numMagicSquares++;
					}
				}
			}

			return numMagicSquares;
		}
	}
}
