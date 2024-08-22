using System.Text;

namespace DailyChallenge
{
	public class Solution019
	{
		public int FindComplement(int num)
		{
			var numBinary = Convert.ToString(num, 2);
			var sb = new StringBuilder();

			foreach (var c in numBinary)
			{
				sb.Append(c == '0' ? '1' : '0');
			}

			return Convert.ToInt32(sb.ToString(), 2);
		}
	}
}
