namespace LeetCode75
{
	public class Solution02
	{
		public string GcdOfStrings(string str1, string str2)
		{
			var shortString = str1.Length < str2.Length ? str1 : str2;

			if (!str1.Contains(shortString) ||
				!str2.Contains(shortString))
			{
				return string.Empty;
			}

			int contSubstring = 1;
			var subString = shortString.Substring(0, contSubstring);
			var maxSubString = string.Empty;

			while (contSubstring <= shortString.Length)
			{
				if (IsDivisible(str1, subString) &&
					IsDivisible(str2, subString))
				{
					maxSubString = subString;
				}

				contSubstring++;
				if (contSubstring <= shortString.Length)
				{
					subString = shortString.Substring(0, contSubstring);
				}
			}

			return maxSubString;
		}

		private bool IsDivisible(string strNumerator, string strDivisor)
		{
			int times = strNumerator.Length / strDivisor.Length;

			return strNumerator == string.Concat(Enumerable.Repeat(strDivisor, times));
		}
	}
}
