namespace TopInterview150
{
	public class Solution055
	{
		public int EvalRPN(string[] tokens)
		{
			var stack = new Stack<int>();

			foreach (var token in tokens)
			{
				if (int.TryParse(token, out var num))
				{
					stack.Push(num);
				}
				else
				{
					var num2 = stack.Pop();
					var num1 = stack.Pop();

					switch (token)
					{
						case "+":
							stack.Push(num1 + num2);
							break;
						case "-":
							stack.Push(num1 - num2);
							break;
						case "*":
							stack.Push(num1 * num2);
							break;
						case "/":
							stack.Push(num1 / num2);
							break;
					}
				}
			}

			return stack.Pop();
		}
	}
}
