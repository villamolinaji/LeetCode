namespace LeetCode75
{
	public class Solution03
	{
		public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
		{
			var maxCandies = candies.Max();
			
			return candies.Select(candy => candy + extraCandies >= maxCandies).ToList();            
		}
	}
}
