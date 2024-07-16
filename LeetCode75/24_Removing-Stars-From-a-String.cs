namespace LeetCode75
{
	public class Solution24
	{
		public string RemoveStars(string s)
		{
			Stack<char> stack = new Stack<char>();

			foreach (char c in s)
			{
				if (c == '*')
				{
					if (stack.Count > 0)
					{
						stack.Pop();
					}
				}
				else
				{
					stack.Push(c);
				}
			}

			char[] result = stack.ToArray();
			Array.Reverse(result);

			return new string(result);
		}
	}
}
