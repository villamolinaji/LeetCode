namespace TopInterview150
{
	public class Solution034
	{
#pragma warning disable S2368 // Public methods should not have multidimensional array parameters
		public bool IsValidSudoku(char[][] board)
#pragma warning restore S2368 // Public methods should not have multidimensional array parameters
		{
			HashSet<string> seen = new HashSet<string>();

			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					char current = board[i][j];
					if (current != '.')
					{
						string row = $"{current}-row-{i}";
						string col = $"{current}-col-{j}";
						string box = $"{current}-box-{i / 3}-{j / 3}";

						if (seen.Contains(row) ||
							seen.Contains(col) ||
							seen.Contains(box))
						{
							return false;
						}

						seen.Add(row);
						seen.Add(col);
						seen.Add(box);
					}
				}
			}

			return true;
		}
	}
}
