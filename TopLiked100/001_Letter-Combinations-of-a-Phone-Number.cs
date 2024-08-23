namespace TopLiked100
{
	public class Solution001
	{
		public IList<string> LetterCombinations(string digits)
		{
			var letters = new List<string> { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
			var output = new List<string>();

			foreach (var digit in digits)
			{
				var digitLetters = letters[(int)char.GetNumericValue(digit) - 2].ToCharArray();

				var outputTemp = new List<string>();

				if (output.Count == 0)
				{
					outputTemp = digitLetters.Select(c => c.ToString()).ToList();
				}
				foreach (var item in output)
				{
					foreach (var letter in digitLetters)
					{
						outputTemp.Add(item + letter);
					}
				}

				output = new List<string>(outputTemp);
			}

			return output;
		}
	}
}
