namespace AmazonSpring
{
	public class Solution02
	{
		public int PartitionString(string s)
		{
			var partitions = 1;
			var subString = s.Substring(0, 1);

			for (int i = 1; i < s.Length; i++)
			{
				if (subString.Contains(s[i]))
				{
					partitions++;
					subString = s[i].ToString();
				}

				subString = $"{subString}{s[i].ToString()}";
			}

			return partitions;
		}
	}
}
