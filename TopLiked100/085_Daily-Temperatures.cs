namespace TopLiked100
{
	public class Solution085
	{
		public int[] DailyTemperatures(int[] temperatures)
		{
			var result = new int[temperatures.Length];

			for (int i = 0; i < temperatures.Length; i++)
			{
				int countDays = 1;
				bool found = false;
				for (int j = i + 1; j < temperatures.Length; j++)
				{
					if (temperatures[j] > temperatures[i])
					{
						result[i] = countDays;
						found = true;
						break;
					}
					countDays++;
				}

				if (!found)
				{
					result[i] = 0;
				}
			}

			return result;
		}
	}
}
