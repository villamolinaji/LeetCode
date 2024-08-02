using System.Text;

namespace TopInterview150
{
	public class Solution018
	{
		public string IntToRoman(int num)
		{
			var roman = new StringBuilder();
			var numString = num.ToString();

			int numLength = numString.Length;
			int position = numLength;

			for (int i = 0; i < numLength; i++)
			{
				var digit = (int)char.GetNumericValue(numString[i]);
				roman.Append(GetRoman(digit, position));

				position--;
			}

			return roman.ToString();
		}

		private string GetRoman(int digit, int position)
		{
			if (position == 1)
			{
				switch (digit)
				{
					case 1:
						return "I";
					case 2:
						return "II";
					case 3:
						return "III";
					case 4:
						return "IV";
					case 5:
						return "V";
					case 6:
						return "VI";
					case 7:
						return "VII";
					case 8:
						return "VIII";
					case 9:
						return "IX";
				}
			}
			else if (position == 2)
			{
				switch (digit)
				{
					case 1:
						return "X";
					case 2:
						return "XX";
					case 3:
						return "XXX";
					case 4:
						return "XL";
					case 5:
						return "L";
					case 6:
						return "LX";
					case 7:
						return "LXX";
					case 8:
						return "LXXX";
					case 9:
						return "XC";
				}
			}
			else if (position == 3)
			{
				switch (digit)
				{
					case 1:
						return "C";
					case 2:
						return "CC";
					case 3:
						return "CCC";
					case 4:
						return "CD";
					case 5:
						return "D";
					case 6:
						return "DC";
					case 7:
						return "DCC";
					case 8:
						return "DCCC";
					case 9:
						return "CM";
				}
			}
			else if (position == 4)
			{
				switch (digit)
				{
					case 1:
						return "M";
					case 2:
						return "MM";
					case 3:
						return "MMM";
				}
			}

			return "";
		}
	}
}
