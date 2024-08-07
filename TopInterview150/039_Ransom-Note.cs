namespace TopInterview150
{
	public class Solution039
	{
		public bool CanConstruct(string ransomNote, string magazine)
		{
			var charGroupRansomNote = ransomNote.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
			var charGroupMagazine = magazine.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

			foreach (var (key, value) in charGroupRansomNote)
			{
				if (!charGroupMagazine.ContainsKey(key) ||
					charGroupMagazine[key] < value)
				{
					return false;
				}
			}

			return true;
		}
	}
}
