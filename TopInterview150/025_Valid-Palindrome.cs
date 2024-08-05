using System.Text.RegularExpressions;

namespace TopInterview150
{
	public class Solution025
	{
		public bool IsPalindrome(string s)
		{
			string pattern = "[^a-zA-Z0-9]";
			string sConverted = Regex.Replace(s.ToLower(), pattern, "");

			var sReversed = sConverted.Reverse();

			return sConverted.SequenceEqual(sReversed);
		}
	}
}
