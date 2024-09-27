namespace ProgrammingSkills
{
	public class Solution29
	{
		public double MyPow(double x, int n)
		{
			if (n == 0)
			{
				return 1;
			}
			if (n == 1)
			{
				return x;
			}

			if (n < 0)
			{
				x = 1 / x;
				n = -n;
			}

			return PowHelper(x, n);
		}

		private double PowHelper(double x, int n)
		{
			if (n == 0)
			{
				return 1;
			}
			if (n == 1)
			{
				return x;
			}

			double half = PowHelper(x, n / 2);

			if (n % 2 == 0)
			{
				return half * half;
			}
			else
			{
				return half * half * x;
			}
		}
	}
}
