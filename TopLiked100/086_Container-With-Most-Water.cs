namespace TopLiked100
{
	public class Solution086
	{
		public int MaxArea(int[] height)
		{
			int maxArea = 0;

			int j = height.Length - 1;
			int i = 0;

			while (i < j)
			{
				int width = j - i;

				int h = 0;

				if (height[j] > height[i])
				{
					h = height[i];
					i++;
				}
				else
				{
					h = height[j];
					j--;
				}

				int area = width * h;

				maxArea = Math.Max(maxArea, area);
			}

			return maxArea;
		}
	}
}
