using System.Text;

namespace LeetCode75
{
	public class Solution71
	{
		public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
		{
			var result = new List<IList<string>>();

			var searchPrefix = new StringBuilder();

			Array.Sort(products);

			foreach (var c in searchWord)
			{
				searchPrefix.Append(c);
				var searchResults = products.Where(p => p.StartsWith(searchPrefix.ToString())).Take(3).ToList();

				result.Add(searchResults);
			}

			return result;
		}
	}
}
