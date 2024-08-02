namespace TopInterview150
{
	public class Solution020
	{
		public string LongestCommonPrefix(string[] strs)
		{
			var strsList = strs.ToList();
			var minStrs = strs.OrderBy(s => s.Length).First();

			var subStringLength = minStrs.Length;

			while (subStringLength > 0)
			{
				var subString = minStrs.Substring(0, subStringLength);

				if (strsList.TrueForAll(s => s.StartsWith(subString)))
				{
					return subString;
				}

				subStringLength--;
			}

			return "";
		}
	}
}
