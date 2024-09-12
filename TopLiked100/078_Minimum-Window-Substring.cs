namespace TopLiked100
{
	public class Solution078
	{
		public string MinWindow(string s, string t)
		{
			var tFreq = new Dictionary<char, int>();
			foreach (char c in t)
			{
				if (tFreq.ContainsKey(c))
				{
					tFreq[c]++;
				}
				else
				{
					tFreq.Add(c, 1);
				}
			}

			var required = tFreq.Count;
			var left = 0;
			var right = 0;
			var formed = 0;

			var windowCounts = new Dictionary<char, int>();
			var windowLength = -1;
			var windowLeft = 0;

			while (right < s.Length)
			{
				char c = s[right];
				if (windowCounts.ContainsKey(c))
				{
					windowCounts[c]++;
				}
				else
				{
					windowCounts.Add(c, 1);
				}

				if (tFreq.ContainsKey(c) &&
					windowCounts[c] == tFreq[c])
				{
					formed++;
				}

				while (left <= right &&
					formed == required)
				{
					c = s[left];

					if (windowLength == -1 ||
						right - left + 1 < windowLength)
					{
						windowLength = right - left + 1;
						windowLeft = left;
					}

					windowCounts[c]--;
					if (tFreq.ContainsKey(c) &&
						windowCounts[c] < tFreq[c])
					{
						formed--;
					}

					left++;
				}

				right++;
			}

			return windowLength == -1 ? "" : s.Substring(windowLeft, windowLength);
		}
	}
}
