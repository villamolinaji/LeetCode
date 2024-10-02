namespace DynamicProgramming
{
	public class Solution02
	{
		public int Fib(int n)
		{
			int firstNumber = 0;
			int secondNumber = 1;

			if (n == 0)
			{
				return firstNumber;
			}

			for (int i = 1; i <= n; i++)
			{
				int aux = firstNumber + secondNumber;
				firstNumber = secondNumber;
				secondNumber = aux;
			}

			return firstNumber;
		}
	}
}
