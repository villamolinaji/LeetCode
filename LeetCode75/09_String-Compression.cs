namespace LeetCode75
{
	public class Solution09
	{
		public int Compress(char[] chars)
		{
			var resultList = new List<string>();

			var index = 1;
			char prevChar = chars[0];
			char curChar;
			int groupLength = 1;

			while (index < chars.Length)
			{
				curChar = chars[index];
				if (prevChar == curChar)
				{
					groupLength++;
				}
				else
				{
					resultList.Add(prevChar.ToString());
					if (groupLength > 1)
					{
						resultList.Add(groupLength.ToString());
					}

					groupLength = 1;
					prevChar = curChar;
				}

				index++;
			}
			
			resultList.Add(prevChar.ToString());
			if (groupLength > 1)
			{
				resultList.Add(groupLength.ToString());
			}
			
			var resultListJoin = String.Join("", resultList);
			for (int i = 0; i < resultListJoin.Length; i++)
			{
				chars[i] = resultListJoin[i];
			}

			return resultListJoin.Length;
		}
	}
}
