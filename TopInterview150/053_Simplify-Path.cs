using System.Text;

namespace TopInterview150
{
	public class Solution053
	{
		public string SimplifyPath(string path)
		{
			var stack = new Stack<string>();

			var parts = path.Split('/');

			foreach (var part in parts)
			{
				if (part != ".")
				{
					if (part == "..")
					{
						stack.TryPop(out _);
					}
					else if (!string.IsNullOrEmpty(part))
					{
						stack.Push(part);
					}
				}
			}

			StringBuilder sb = new StringBuilder();

			var stackReverser = stack.Reverse();

			foreach (var item in stackReverser)
			{
				sb.Append("/");
				sb.Append(item);
			}

			if (sb.Length == 0)
			{
				sb.Append("/");
			}

			return sb.ToString();
		}
	}
}
