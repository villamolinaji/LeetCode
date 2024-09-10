namespace TopLiked100
{
	public class Solution031
	{
		public int LongestValidParentheses(string s)
		{
#pragma warning disable S125 // Sections of code should not be commented out
			//if (s.Length == 0)
			//{
			//	return 0;
			//}

			//int[] dp = new int[s.Length];
			//int maxLength = 0;

			//for (int i = 1; i < s.Length; i++)
			//{
			//	if (s[i] == ')')
			//	{					
			//		if (s[i - 1] == '(')
			//		{
			//			dp[i] = (i >= 2 ? dp[i - 2] : 0) + 2;
			//		}					
			//		else if (i - dp[i - 1] > 0 && 
			//			s[i - dp[i - 1] - 1] == '(')
			//		{
			//			dp[i] = dp[i - 1] + (i - dp[i - 1] >= 2 ? dp[i - dp[i - 1] - 2] : 0) + 2;
			//		}

			//		maxLength = Math.Max(maxLength, dp[i]);
			//	}
			//}

			//return maxLength;
#pragma warning restore S125 // Sections of code should not be commented out

			var stack = new Stack<int>();
			stack.Push(-1);
			int maxLength = 0;

			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == '(')
				{
					stack.Push(i);
				}
				else
				{
					stack.Pop();

					if (stack.Count == 0)
					{
						stack.Push(i);
					}
					else
					{
						int currentLength = i - stack.Peek();
						maxLength = Math.Max(maxLength, currentLength);
					}
				}
			}

			return maxLength;
		}
	}
}
