namespace LeetCode75
{
	public class Solution23
	{
		public int EqualPairs(int[][] grid)
		{
			int gridLength = grid.Length;
			int countEqualPairs = 0;

			Dictionary<string, int> rowMap = new Dictionary<string, int>();
			Dictionary<string, int> colMap = new Dictionary<string, int>();

			for (int r = 0; r < gridLength; r++)
			{
				string rowStr = string.Join(",", grid[r]);
				if (rowMap.ContainsKey(rowStr))
				{
					rowMap[rowStr]++;
				}
				else
				{
					rowMap[rowStr] = 1;
				}
			}

			for (int c = 0; c < gridLength; c++)
			{
				List<int> colList = new List<int>();
				for (int r = 0; r < gridLength; r++)
				{
					colList.Add(grid[r][c]);
				}
				string colStr = string.Join(",", colList);
				if (colMap.ContainsKey(colStr))
				{
					colMap[colStr]++;
				}
				else
				{
					colMap[colStr] = 1;
				}
			}

#pragma warning disable S3267 // Loops should be simplified with "LINQ" expressions
			foreach (var row in rowMap)
			{
				if (colMap.ContainsKey(row.Key))
				{
					countEqualPairs += row.Value * colMap[row.Key];
				}
			}
#pragma warning restore S3267 // Loops should be simplified with "LINQ" expressions

			return countEqualPairs;
		}
	}
}
