namespace TopInterview150
{
	public class Solution017
	{
		public int RomanToInt(string s)
		{
			int result = 0;
			var minusChars = new List<char>() { 'I', 'X', 'C' };

			for (int i = 0; i < s.Length; i++)
			{
				var value = GetValue(s[i]);

				if (minusChars.Contains(s[i])
					&& i + 1 < s.Length
					&& value < GetValue(s[i + 1]))
				{
					result -= value;
				}
				else
				{
					result += value;
				}
			}

			return result;
		}

		private int GetValue(char c)
		{
			switch (c)
			{
				case 'I':
					return 1;
				case 'V':
					return 5;
				case 'X':
					return 10;
				case 'L':
					return 50;
				case 'C':
					return 100;
				case 'D':
					return 500;
				case 'M':
					return 1000;
				default:
					return 0;
			}
		}
	}
}
