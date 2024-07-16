namespace LeetCode75
{
	public class Solution22
	{
		public bool CloseStrings(string word1, string word2)
		{			
			if (word1.Length != word2.Length)
			{
				return false;
			}
			
			var chars1 = new HashSet<char>(word1);
			var chars2 = new HashSet<char>(word2);
			if (!chars1.SetEquals(chars2))
			{
				return false;
			}
			
			var freqChar1 = new Dictionary<char, int>();
			var freqChar2 = new Dictionary<char, int>();

			foreach (var c in word1)
			{
				if (freqChar1.ContainsKey(c))
				{
					freqChar1[c]++;
				}
				else
				{
					freqChar1[c] = 1;
				}
			}

			foreach (var c in word2)
			{
				if (freqChar2.ContainsKey(c))
				{
					freqChar2[c]++;
				}
				else
				{
					freqChar2[c] = 1;
				}
			}
			
			var freqValues1 = freqChar1.Values.ToList();
			var freqValues2 = freqChar2.Values.ToList();
			freqValues1.Sort();
			freqValues2.Sort();

			return freqValues1.SequenceEqual(freqValues2);
		}
	}
}
