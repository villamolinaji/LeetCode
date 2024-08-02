using System.Text;

namespace TopInterview150
{
	public class Solution022
	{
		public string Convert(string s, int numRows)
		{
			var list = new List<StringBuilder>();
			for (int i = 0; i < numRows; i++)
			{
				list.Add(new StringBuilder());
			}

			var indexList = 0;
			var isGoingDown = false;
			for (int i = 0; i < s.Length; i++)
			{
				list[indexList].Append(s[i]);

				if (isGoingDown)
				{
					indexList--;

					if (indexList <= 0)
					{
						isGoingDown = false;
						indexList = 0;
					}
				}
				else
				{
					indexList++;

					if (indexList >= numRows - 1)
					{
						isGoingDown = true;
						indexList = numRows - 1;
					}
				}
			}

			var result = new StringBuilder();
			foreach (var item in list)
			{
				result.Append(item);
			}

			return result.ToString();
		}
	}
}
