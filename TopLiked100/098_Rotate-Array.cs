namespace TopLiked100
{
	public class Solution098
	{
		public void Rotate(int[] nums, int k)
		{
			if (k > nums.Length)
			{
				k = k % nums.Length;
			}

			var newNums = new int[nums.Length];
			for (int i = 0; i < nums.Length; i++)
			{
				var posB = (nums.Length - (k - i)) % nums.Length;

				newNums[i] = nums[posB];
			}

			Array.Copy(newNums, nums, nums.Length);
		}
	}
}
