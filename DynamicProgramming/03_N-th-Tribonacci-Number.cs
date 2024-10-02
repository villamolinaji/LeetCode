namespace DynamicProgramming
{
	public class Solution03
	{
		public int Tribonacci(int n)
		{
			int tribonacci = 0;
			int valueN = 0;
			int valueN1 = 1;
			int valueN2 = 1;

			if (n == 1 || n == 2)
			{
				tribonacci = 1;
			}

			for (int i = 0; i < n - 2; i++)
			{
				tribonacci = valueN + valueN1 + valueN2;

				valueN = valueN1;
				valueN1 = valueN2;
				valueN2 = tribonacci;
			}

			return tribonacci;
		}
	}
}
