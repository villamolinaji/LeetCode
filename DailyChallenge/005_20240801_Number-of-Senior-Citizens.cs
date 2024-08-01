namespace DailyChallenge
{
	public class Solution005
	{
		public int CountSeniors(string[] details)
		{
			var ages = details.Select(details => int.Parse(details.Substring(11, 2))).ToList();

			return ages.Count(age => age > 60);
		}
	}
}
