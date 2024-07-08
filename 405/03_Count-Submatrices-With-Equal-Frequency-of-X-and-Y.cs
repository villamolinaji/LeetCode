namespace _405
{
	public static class Solution03
	{
#pragma warning disable S2368 // Public methods should not have multidimensional array parameters
		public static int NumberOfSubmatrices(char[][] grid)
#pragma warning restore S2368 // Public methods should not have multidimensional array parameters
		{
			int lengthX = grid.Length;
			int lengthY = grid[0].Length;
			
			int[,] differences = new int[lengthX, lengthY];
			bool[,] XY_find = new bool[lengthX, lengthY];

			switch (grid[0][0])
			{
				case 'X': 
					differences[0, 0] = 1; 
					XY_find[0, 0] = true; 
					break;
				case 'Y': 
					differences[0, 0] = -1; 
					break;
				default: 
					differences[0, 0] = 0; 
					break;				
			}

			for (int x = 1; x < lengthX; x++)
			{
				if (grid[x][0] == 'X')
				{
					XY_find[x, 0] = true;
				}

				XY_find[x, 0] = XY_find[x, 0] || XY_find[x - 1, 0];
				differences[x, 0] = (grid[x][0]) switch
				{
					'X' => differences[x - 1, 0] + 1,
					'Y' => differences[x - 1, 0] - 1,
					_ => differences[x - 1, 0]
				};
			}
			
			for (int y = 1; y < lengthY; y++)
			{
				if (grid[0][y] == 'X')
				{
					XY_find[0, y] = true;
				}

				XY_find[0, y] = XY_find[0, y - 1] || XY_find[0, y];
				differences[0, y] = (grid[0][y]) switch
				{
					'X' => differences[0, y - 1] + 1,
					'Y' => differences[0, y - 1] - 1,
					_ => differences[0, y - 1]
				};
			}

			for (int x = 1; x < lengthX; x++)
			{
				for (int y = 1; y < lengthY; y++)
				{
					if (grid[x][y] == 'X')
					{
						XY_find[x, y] = true;
					}
					XY_find[x, y] = XY_find[x, y] || XY_find[x - 1, y] || XY_find[x, y - 1];

					differences[x, y] = differences[x - 1, y] + differences[x, y - 1] - differences[x - 1, y - 1];

					switch (grid[x][y])
					{
						case 'X': differences[x, y] += 1; break;
						case 'Y': differences[x, y] += -1; break;
						default: break;
					}
				}
			}

			int submatrices = 0;
			for (int x = 0; x < lengthX; x++)
			{
				for (int y = 0; y < lengthY; y++)
				{
					if (differences[x, y] == 0 && XY_find[x, y])
					{
						submatrices++;
					}
				}
			}

			return submatrices;
		}
	}
}