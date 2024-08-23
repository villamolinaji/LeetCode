namespace DailyChallenge
{
	public class Solution020
	{
		public string FractionAddition(string expression)
		{
			var numerator = 0;
			var denominator = 1;

			var i = 0;
			while (i < expression.Length)
			{
				var sign = 1;
				if (expression[i] == '+' || expression[i] == '-')
				{
					sign = expression[i] == '-' ? -1 : 1;
					i++;
				}

				var num = 0;
				while (i < expression.Length && char.IsDigit(expression[i]))
				{
					num = num * 10 + (int)char.GetNumericValue(expression[i]);
					i++;
				}
				num *= sign;
				i++;

				var denom = 0;
				while (i < expression.Length && char.IsDigit(expression[i]))
				{
					denom = denom * 10 + (int)char.GetNumericValue(expression[i]);
					i++;
				}

				numerator = numerator * denom + num * denominator;
				denominator *= denom;
			}

			var gcd = GCD(Math.Abs(numerator), denominator);
			numerator /= gcd;
			denominator /= gcd;

			return numerator + "/" + denominator;
		}

		private int GCD(int a, int b)
		{
			if (b == 0)
			{
				return a;
			}

			return GCD(b, a % b);
		}
	}
}
