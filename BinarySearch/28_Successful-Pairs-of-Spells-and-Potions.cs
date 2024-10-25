namespace BinarySearch
{
	public class Solution28
	{
		public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
		{
			Array.Sort(potions);
			int[] resultArray = new int[spells.Length];

			for (int i = 0; i < spells.Length; i++)
			{
				int left = 0;
				int right = potions.Length - 1;
				int leftMostIdx = -1;

				while (left <= right)
				{
					int middle = (left + right) / 2;
					if (((long)spells[i]) * potions[middle] >= success)
					{
						leftMostIdx = middle;
						right = middle - 1;
					}
					else
					{
						left = middle + 1;
					}
				}

				resultArray[i] = leftMostIdx == -1
					? 0
					: potions.Length - leftMostIdx;
			}

			return resultArray;
		}
	}
}
