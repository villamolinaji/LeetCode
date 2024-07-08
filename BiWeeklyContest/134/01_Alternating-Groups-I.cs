namespace _134
{
	public class Solution01
	{
		public int NumberOfAlternatingGroups(int[] colors)
		{
			int numAlternatingGroups = 0;
			for (int i = 0; i < colors.Length; i++)
			{
				var left = i == 0 ? colors[colors.Length - 1] : colors[i - 1];
				var right = i == colors.Length - 1 ? colors[0] : colors[i + 1];	
				if (left == right && left != colors[i])
				{
					numAlternatingGroups++;
				}
			}

			return numAlternatingGroups;
		}
	}
}
