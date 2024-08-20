namespace TopInterview150
{
	public class WordDictionary
	{
		private sealed class TrieNode
		{
			public Dictionary<char, TrieNode> Children { get; set; }
			public bool IsEndOfWord { get; set; }

			public TrieNode()
			{
				Children = new Dictionary<char, TrieNode>();
				IsEndOfWord = false;
			}
		}

		private TrieNode Root { get; set; }

		public WordDictionary()
		{
			Root = new TrieNode();
		}

		public void AddWord(string word)
		{
			TrieNode node = Root;
			foreach (char c in word)
			{
				if (!node.Children.ContainsKey(c))
				{
					node.Children[c] = new TrieNode();
				}
				node = node.Children[c];
			}
			node.IsEndOfWord = true;
		}

		public bool Search(string word)
		{
			return SearchInNode(word, 0, Root);
		}

		private bool SearchInNode(string word, int index, TrieNode node)
		{
			if (index == word.Length)
			{
				return node.IsEndOfWord;
			}

			char c = word[index];
			if (c == '.')
			{
#pragma warning disable S3267 // Loops should be simplified with "LINQ" expressions
				foreach (var child in node.Children)
				{
					if (SearchInNode(word, index + 1, child.Value))
					{
						return true;
					}
				}
#pragma warning restore S3267 // Loops should be simplified with "LINQ" expressions

				return false;
			}
			else
			{
				if (!node.Children.ContainsKey(c))
				{
					return false;
				}

				return SearchInNode(word, index + 1, node.Children[c]);
			}
		}
	}
}
