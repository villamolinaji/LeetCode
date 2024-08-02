namespace TopInterview150
{
	public class Solution021
	{
		public string ReverseWords(string s)
		{
			var splitS = s.Split(" ");
			var splitReverse = splitS.Reverse();

			return String.Join(" ", splitReverse.Where(s => s != ""));
		}
	}
}
