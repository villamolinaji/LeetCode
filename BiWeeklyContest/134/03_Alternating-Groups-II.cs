namespace _134
{
	public class Solution03
	{
		public int NumberOfAlternatingGroups(int[] colors, int k)
		{
			int colorsLength = colors.Length;
			int posL = 0;
			int posR = 0;
			int countAdjacent = 0;

			while (posR < k - 1)				
			{
				if (colors[posR] == colors[posR + 1])
				{
					countAdjacent++;
				}
				posR++;
			}

			int alternatingGroups = 0;
			while (posL < colorsLength)
			{
				if (countAdjacent == 0)
				{
					alternatingGroups++;
				}

				if (colors[posL] == colors[(posL + 1) % colorsLength])
				{
					countAdjacent--;
				}
				posL++;

				if (colors[posR % colorsLength] == colors[(posR + 1) % colorsLength])
				{
					countAdjacent++;
				}
				posR++;
			}

			return alternatingGroups;
		}
	}
}
