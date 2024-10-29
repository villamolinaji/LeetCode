namespace GraphTheory
{
	public class Solution12
	{
		public int LadderLength(string beginWord, string endWord, IList<string> wordList)
		{
			var wordListHashSet = new HashSet<string>(wordList);
			if (!wordListHashSet.Contains(endWord))
			{
				return 0;
			}

			var queue = new Queue<string>();
			queue.Enqueue(beginWord);
			var ladderLength = 1;

			while (queue.Count > 0)
			{
				var queueLength = queue.Count;

				for (int i = 0; i < queueLength; i++)
				{
					var currentWord = queue.Dequeue();

					if (currentWord == endWord)
					{
						return ladderLength;
					}

					var currentWordArray = currentWord.ToCharArray();

					for (int j = 0; j < currentWordArray.Length; j++)
					{
						var currentWordChar = currentWordArray[j];

						for (char c = 'a'; c <= 'z'; c++)
						{
							if (c == currentWordChar)
							{
								continue;
							}

							currentWordArray[j] = c;
							var newWord = new string(currentWordArray);

							if (wordListHashSet.Contains(newWord))
							{
								queue.Enqueue(newWord);
								wordListHashSet.Remove(newWord);
							}
						}

						currentWordArray[j] = currentWordChar;
					}
				}

				ladderLength++;
			}

			return 0;
		}
	}
}
