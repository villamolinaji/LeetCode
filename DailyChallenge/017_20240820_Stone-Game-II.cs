namespace DailyChallenge
{
	public class Solution017
	{
		private int[,]? MemoStones { get; set; }
		private int[]? PrefixSum { get; set; }

		public int StoneGameII(int[] piles)
		{
			int pilesLength = piles.Length;
			MemoStones = new int[pilesLength, pilesLength + 1];
			PrefixSum = new int[pilesLength + 1];

			for (int i = pilesLength - 1; i >= 0; --i)
			{
				PrefixSum[i] = PrefixSum[i + 1] + piles[i];
			}

			return DP(0, 1);
		}

		private int DP(int i, int m)
		{
			int maxStones = 0;

			if (MemoStones != null && PrefixSum != null)
			{
				int memoStonesLength = MemoStones.GetLength(0);

				if (i == memoStonesLength)
				{
					return 0;
				}

				if (MemoStones[i, m] != 0)
				{
					return MemoStones[i, m];
				}

				for (int x = 1; x <= 2 * m && i + x <= memoStonesLength; ++x)
				{
					maxStones = Math.Max(maxStones, PrefixSum[i] - DP(i + x, Math.Max(m, x)));
				}

				MemoStones[i, m] = maxStones;
			}

			return maxStones;
		}
	}
}
