using System.Text;

namespace TopLiked100
{
	public class Solution053
	{
		public IList<IList<string>> GroupAnagrams(string[] strs)
		{
			var result = new List<IList<string>>();
			var listDictionary = new List<(Dictionary<char, int>, string)>();

			foreach (var str in strs)
			{
				var charGroup = str
					.GroupBy(c => c)
					.OrderBy(c => c.Count())
					.ThenBy(c => c.Key)
					.ToDictionary(g => g.Key, g => g.Count());
				listDictionary.Add((charGroup, str));
			}

			var visited = new Dictionary<string, List<string>>();
			foreach (var dictionary in listDictionary)
			{
				var dictionaryString = DictionaryToString(dictionary.Item1);
				if (visited.ContainsKey(dictionaryString))
				{
					visited[dictionaryString].Add(dictionary.Item2);
				}
				else
				{
					visited.Add(dictionaryString, new List<string>());
					visited[dictionaryString].Add(dictionary.Item2);
				}
			}

			foreach (var item in visited)
			{
				result.Add(item.Value);
			}

			return result;
		}

		private string DictionaryToString(Dictionary<char, int> dictionary)
		{
			var sb = new StringBuilder();

			foreach (var item in dictionary)
			{
				sb.Append(item.Key);
				sb.Append(item.Value);
			}

			return sb.ToString();
		}
	}
}
