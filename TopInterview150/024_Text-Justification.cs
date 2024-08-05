using System.Text;
using System.Text.RegularExpressions;

namespace TopInterview150
{
	public class Solution024
	{
		public IList<string> FullJustify(string[] words, int maxWidth)
		{
			var result = new List<string>();
			var stringBuilder = new StringBuilder();
			var wordsLength = words.Length;

			for (int i = 0; i < wordsLength; i++)
			{
				var word = words[i];
				var lenWord = word.Length;
				var currentWidth = stringBuilder.Length;
				var lenCurrentWidth = currentWidth == 0 ? 0 : currentWidth + 1;

				if (lenWord + lenCurrentWidth <= maxWidth)
				{
					stringBuilder.Append(lenCurrentWidth == 0 ? word : " " + word);

					if (i == wordsLength - 1)
					{
						for (int j = stringBuilder.Length; j < maxWidth; j++)
						{
							stringBuilder.Append(" ");
						}
					}
				}
				else
				{
					Regex regex = new Regex(@" +(?=.)");
					var match = regex.Match(stringBuilder.ToString());
					var indexSpace = match.Index;
					if (indexSpace > 0)
					{
						for (int j = stringBuilder.Length; j < maxWidth; j++)
						{
							stringBuilder.Insert(indexSpace, " ");
							match = regex.Match(stringBuilder.ToString(), indexSpace + match.Length + 1);
							indexSpace = match.Index;
							if (indexSpace <= 0)
							{
								match = regex.Match(stringBuilder.ToString());
								indexSpace = match.Index;
							}
						}
					}
					else
					{
						for (int j = stringBuilder.Length; j < maxWidth; j++)
						{
							stringBuilder.Append(" ");
						}
					}

					result.Add(stringBuilder.ToString());
					stringBuilder.Clear();
					stringBuilder.Append(word);
				}
			}

			if (stringBuilder.Length > 0)
			{
				for (int j = stringBuilder.Length; j < maxWidth; j++)
				{
					stringBuilder.Append(" ");
				}

				result.Add(stringBuilder.ToString());
			}

			return result;
		}
	}
}
