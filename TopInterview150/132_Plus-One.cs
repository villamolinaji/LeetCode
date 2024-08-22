namespace TopInterview150
{
	public class Solution132
	{
		public int[] PlusOne(int[] digits)
		{
			return PlusOne(digits, digits.Length - 1);
		}

		private int[] PlusOne(int[] digits, int index)
		{
			if (index < 0)
			{
				var newDigits = new int[digits.Length + 1];
				newDigits[0] = 1;
				return newDigits;
			}

			if (digits[index] < 9)
			{
				digits[index]++;
				return digits;
			}

			digits[index] = 0;

			return PlusOne(digits, index - 1);
		}
	}
}
