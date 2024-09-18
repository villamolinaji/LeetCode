namespace ProgrammingSkills
{
	public class Solution09
	{
		public bool CanMakeArithmeticProgression(int[] arr)
		{
			arr = arr.Order().ToArray();
			var firstDifference = Math.Abs(arr[1] - arr[0]);

			for (int i = 2; i < arr.Length; i++)
			{
				if (Math.Abs(arr[i] - arr[i - 1]) != firstDifference)
				{
					return false;
				}
			}

			return true;
		}
	}
}
