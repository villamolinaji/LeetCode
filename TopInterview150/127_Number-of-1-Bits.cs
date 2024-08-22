namespace TopInterview150
{
	public class Solution127
	{
		public int HammingWeight(int n)
		{
			var nBinaryString = Convert.ToString(n, 2);

			return nBinaryString.Count(c => c == '1');
		}
	}
}
