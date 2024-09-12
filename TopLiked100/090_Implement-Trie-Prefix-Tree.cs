namespace TopLiked100
{
	public class Trie
	{

		public HashSet<string> TrieList { get; set; }

		public Trie()
		{
			TrieList = new HashSet<string>();
		}

		public void Insert(string word)
		{
			TrieList.Add(word);
		}

		public bool Search(string word)
		{
			return TrieList.Contains(word);
		}

		public bool StartsWith(string prefix)
		{
			return TrieList.Any(t => t.StartsWith(prefix));
		}
	}
}
