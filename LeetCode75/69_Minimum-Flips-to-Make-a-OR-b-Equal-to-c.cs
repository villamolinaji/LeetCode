namespace LeetCode75
{
	public class Solution69
	{
		public int MinFlips(int a, int b, int c)
		{
			var binaryA = Convert.ToString(a, 2);
			var binaryB = Convert.ToString(b, 2);
			var binaryC = Convert.ToString(c, 2);

			int flips = 0;

			if (binaryA.Length < binaryB.Length)
			{
				binaryA = binaryA.PadLeft(binaryB.Length, '0');
			}
			else if (binaryB.Length < binaryA.Length)
			{
				binaryB = binaryB.PadLeft(binaryA.Length, '0');
			}

			if (binaryC.Length < binaryA.Length)
			{
				binaryC = binaryC.PadLeft(binaryA.Length, '0');
			}
			else
			{
				binaryA = binaryA.PadLeft(binaryC.Length, '0');
				binaryB = binaryB.PadLeft(binaryC.Length, '0');
			}

			for (int i = 0; i < binaryA.Length; i++)
			{
				if (binaryC[i] == '1')
				{
					if (binaryA[i] == '0' && binaryB[i] == '0')
					{
						flips++;
					}
				}
				else
				{
					if (binaryA[i] == '1')
					{
						flips++;
					}
					if (binaryB[i] == '1')
					{
						flips++;
					}
				}
			}

			return flips;
		}
	}
}
