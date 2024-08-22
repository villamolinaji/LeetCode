namespace TopInterview150
{
	public class Solution131
	{
		public bool IsPalindrome(int x)
		{
			var xStr = x.ToString();

			var reverse = xStr.Reverse();

			return reverse.SequenceEqual(xStr);
		}
	}
}
