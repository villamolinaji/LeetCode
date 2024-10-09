namespace DynamicProgramming
{
	public class Solution25
	{
		public int[] LongestObstacleCourseAtEachPosition(int[] obstacles)
		{
			int obstaclesLength = obstacles.Length;
			int[] result = new int[obstaclesLength];

			List<int> lis = new List<int>();

			for (int i = 0; i < obstaclesLength; i++)
			{
				int obstacle = obstacles[i];

				int index = BinarySearch(lis, obstacle);

				if (index == lis.Count)
				{
					lis.Add(obstacle);
				}
				else
				{
					lis[index] = obstacle;
				}

				result[i] = index + 1;
			}

			return result;
		}

		private static int BinarySearch(List<int> lis, int target)
		{
			int left = 0;
			int right = lis.Count;

			while (left < right)
			{
				int mid = left + (right - left) / 2;

				if (lis[mid] <= target)
				{
					left = mid + 1;
				}
				else
				{
					right = mid;
				}
			}

			return left;
		}
	}
}
