using System.Text;

namespace TopInterview150
{
	public class Solution125
	{
		public string AddBinary(string a, string b)
		{
			var aLength = a.Length - 1;
			var bLength = b.Length - 1;
			var carry = 0;
			var sb = new StringBuilder();

			while (aLength >= 0 ||
				bLength >= 0 ||
				carry > 0)
			{
				var sum = carry;

				if (aLength >= 0)
				{
					sum += a[aLength] - '0';
					aLength--;
				}

				if (bLength >= 0)
				{
					sum += b[bLength] - '0';
					bLength--;
				}

				carry = sum / 2;
				sb.Append(sum % 2);
			}

			return Reverse(sb.ToString());
		}

		private string Reverse(string s)
		{
			var sCharArray = s.ToCharArray();

			Array.Reverse(sCharArray);

			return new string(sCharArray);
		}
	}
}
