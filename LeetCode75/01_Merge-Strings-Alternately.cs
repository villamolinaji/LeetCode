using System.Text;

namespace LeetCode75
{
	public class Solution01
	{
		public string MergeAlternately(string word1, string word2)
		{
			var maxLength = Math.Max(word1.Length, word2.Length);
			var sbResult = new StringBuilder();

			for (int i = 0; i < maxLength; i++)
			{
				if (i < word1.Length)
				{
					sbResult.Append(word1[i]);
				}

				if (i < word2.Length)
				{
					sbResult.Append(word2[i]);
				}
			}

			return sbResult.ToString();
		}
	}
}
