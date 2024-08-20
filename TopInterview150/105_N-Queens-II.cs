namespace TopInterview150
{
	public class Solution105
	{
		private int CountSolutions { get; set; } = 0;

		public int TotalNQueens(int n)
		{
			var cols = new bool[n];
			var diags1 = new bool[2 * n];
			var diags2 = new bool[2 * n];

			Backtrack(0, n, cols, diags1, diags2);

			return CountSolutions;
		}

		private void Backtrack(int row, int n, bool[] cols, bool[] diag1, bool[] diag2)
		{
			if (row == n)
			{
				CountSolutions++;
				return;
			}

			for (int col = 0; col < n; col++)
			{
				int d1 = col - row + n;
				int d2 = col + row;

				if (cols[col] ||
					diag1[d1] ||
					diag2[d2])
				{
					continue;
				}

				cols[col] = true;
				diag1[d1] = true;
				diag2[d2] = true;

				Backtrack(row + 1, n, cols, diag1, diag2);

				cols[col] = false;
				diag1[d1] = false;
				diag2[d2] = false;
			}
		}
	}
}
