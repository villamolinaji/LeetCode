using System.Text;

namespace TopLiked100
{
	public class Solution084
	{
		public string DecodeString(string s)
		{
			Stack<int> countStack = new Stack<int>();
			Stack<StringBuilder> stringStack = new Stack<StringBuilder>();
			StringBuilder currentString = new StringBuilder();
			int num = 0;

			foreach (char c in s)
			{
				if (char.IsDigit(c))
				{
					num = num * 10 + (c - '0');
				}
				else if (c == '[')
				{
					countStack.Push(num);
					stringStack.Push(currentString);
					currentString = new StringBuilder();
					num = 0;
				}
				else if (c == ']')
				{
					int repeatTimes = countStack.Pop();
					StringBuilder decodedString = stringStack.Pop();
					for (int i = 0; i < repeatTimes; i++)
					{
						decodedString.Append(currentString);
					}
					currentString = decodedString;
				}
				else
				{
					currentString.Append(c);
				}
			}

			return currentString.ToString();
		}
	}
}
