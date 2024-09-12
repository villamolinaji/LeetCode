namespace TopLiked100
{
	public class Solution081
	{
		public bool IsValid(string s)
		{
			var charStack = new Stack<char>();

			foreach (var c in s)
			{
				if (c == '(' || c == '[' || c == '{')
				{
					charStack.Push(c);
				}
				else
				{
					if (charStack.Count == 0)
					{
						return false;
					}

					var top = charStack.Pop();

					switch (c)
					{
						case ')':
							if (top != '(')
							{
								return false;
							}
							break;
						case ']':
							if (top != '[')
							{
								return false;
							}
							break;
						case '}':
							if (top != '{')
							{
								return false;
							}
							break;
					}
				}
			}

			if (charStack.Count > 0)
			{
				return false;
			}

			return true;
		}
	}
}
