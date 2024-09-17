namespace ProgrammingSkills
{
	public class Solution05
	{
		public bool RepeatedSubstringPattern(string s)
		{
			/*
			var indexStartSub = 0;
			var indexEndSub = 1;
			var sLength = s.Length;

			while (indexEndSub < sLength)
			{
				var subString = s.Substring(indexStartSub, indexEndSub - indexStartSub);

				var multipleIndex = sLength / subString.Length;

				var repeatedSubString = new StringBuilder();

				for (var i = 0; i < multipleIndex; i++)
				{
					repeatedSubString.Append(subString);
				}

				if (repeatedSubString.ToString() == s)
				{
					return true;
				}

				indexEndSub++;
			}

			return false;
			*/

			string doubledString = $"{s}{s}";
			doubledString = doubledString.Substring(1, doubledString.Length - 2);

			return doubledString.Contains(s);
		}
	}
}
