namespace LeetCode75
{
	public class Solution05
	{
		public string ReverseVowels(string s)
		{
			int startIndex = 0;
			int endIndex = s.Length - 1;

			var sArrayAux = s.ToCharArray();

			while (startIndex < endIndex)
			{
				if (!IsVowel(s[startIndex]))
				{
					startIndex++;
					continue;
				}

				if (!IsVowel(s[endIndex]))
				{
					endIndex--;
					continue;
				}

				var auxChar = sArrayAux[startIndex];
				sArrayAux[startIndex] = sArrayAux[endIndex];
				sArrayAux[endIndex] = auxChar;
				
				startIndex++;
				endIndex--;
			}

			return new string(sArrayAux);
		}

		private bool IsVowel(char s)
		{
			var charString = s.ToString().ToUpper();

			return charString == "A" ||
				charString == "E" ||
				charString == "I" ||
				charString == "O" ||
				charString == "U";				
		}
	}
}
