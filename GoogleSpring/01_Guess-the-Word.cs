namespace GoogleSpring
{
	public class Master
	{
#pragma warning disable S2325 // Methods and properties that don't access instance data should be static
		public int Guess(string word)
#pragma warning restore S2325 // Methods and properties that don't access instance data should be static
		{
			return 0;
		}
	}

	public class Solution01
	{
		public void FindSecretWord(string[] words, Master master)
		{
			var possibleWords = words.ToList();
			possibleWords.Sort((a, b) => String.Compare(a, b));
			var curWord = "";
			var curCorrectChars = 0;

			for (var i = 0; i < words.Length - 1; i++)
			{
				if (i % 2 == 0)
				{
					curWord = possibleWords[0];
				}
				else
				{
					curWord = possibleWords[^1];
				}

				curCorrectChars = master.Guess(curWord);
				possibleWords.Remove(curWord);

				if (curCorrectChars == 6)
				{
					return;
				}

				if (curCorrectChars == 0)
				{
					possibleWords = RemoveImpossibleWords(possibleWords, curWord);

					continue;
				}

				possibleWords = SelectPossibleWords(possibleWords, curWord, curCorrectChars);
			}
		}

		private List<string> SelectPossibleWords(List<string> words, string curWord, int curCorrectChars)
		{
			var result = new List<string>();

			foreach (var w in words)
			{
				var tmpCorrect = 0;

				for (var i = 0; i < 6; i++)
				{
					if (w[i] == curWord[i])
					{
						tmpCorrect++;
					}
				}

				if (tmpCorrect == curCorrectChars)
				{
					result.Add(w);
				}
			}

			return result;
		}

		private List<string> RemoveImpossibleWords(List<string> words, string curWord)
		{
			var result = new List<string>();

			foreach (var w in words)
			{
				var isSame = false;

				for (var i = 0; i < 6; i++)
				{
					if (w[i] == curWord[i])
					{
						isSame = true;
						break;
					}
				}

				if (!isSame)
				{
					result.Add(w);
				}
			}

			return result;
		}
	}
}
