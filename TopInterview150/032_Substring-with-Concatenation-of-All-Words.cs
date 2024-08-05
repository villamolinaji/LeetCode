namespace TopInterview150
{
	public class Solution032
	{
		public IList<int> FindSubstring(string s, string[] words)
		{
			IList<int> result = new List<int>();

			int wordLength = words[0].Length;
			int wordsCount = words.Length;

			Dictionary<string, int> wordMap = new Dictionary<string, int>();
			foreach (var word in words)
			{
				if (wordMap.ContainsKey(word))
				{
					wordMap[word]++;
				}
				else
				{
					wordMap.Add(word, 1);
				}
			}

			for (int i = 0; i < wordLength; i++)
			{
				int left = i;
				int right = i;
				int count = 0;
				Dictionary<string, int> currentMap = new Dictionary<string, int>();

				while (right + wordLength <= s.Length)
				{
					string word = s.Substring(right, wordLength);
					right += wordLength;

					if (wordMap.ContainsKey(word))
					{
						if (currentMap.ContainsKey(word))
						{
							currentMap[word]++;
						}
						else
						{
							currentMap.Add(word, 1);
						}

						count++;

						while (currentMap[word] > wordMap[word])
						{
							string leftWord = s.Substring(left, wordLength);
							left += wordLength;
							currentMap[leftWord]--;
							count--;
						}

						if (count == wordsCount)
						{
							result.Add(left);
						}
					}
					else
					{
						currentMap.Clear();
						count = 0;
						left = right;
					}
				}
			}

			return result;
		}
	}
}
