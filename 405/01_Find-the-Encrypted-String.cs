namespace _405
{
	public static class Solution01
	{
		public static string GetEncryptedString(string s, int k)
		{
			var result = string.Empty;
			for (int i = 0; i < s.Length; i++)
			{
				var pos = (k + i) % s.Length;
				result = $"{result}{s[pos]}";
			}

			return result;
		}
	}
}