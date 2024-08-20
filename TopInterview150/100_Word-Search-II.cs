namespace TopInterview150
{
	public class Solution100
	{
		private sealed class TrieNode
		{
			public Dictionary<char, TrieNode> Children { get; set; } = new Dictionary<char, TrieNode>();
			public string? Word { get; set; } = null;
		}

		public IList<string> FindWords(char[][] board, string[] words)
		{
			var result = new List<string>();
			TrieNode root = BuildTrie(words);

			var rows = board.Length;
			var cols = board[0].Length;

			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < cols; c++)
				{
					if (root.Children.ContainsKey(board[r][c]))
					{
						DFS(board, r, c, root, result);
					}
				}
			}

			return result;
		}

		private TrieNode BuildTrie(string[] words)
		{
			TrieNode root = new TrieNode();
			foreach (string word in words)
			{
				TrieNode node = root;
				foreach (char c in word)
				{
					if (!node.Children.ContainsKey(c))
					{
						node.Children[c] = new TrieNode();
					}
					node = node.Children[c];
				}

				node.Word = word;
			}

			return root;
		}

		private void DFS(char[][] board, int r, int c, TrieNode node, List<string> result)
		{
			char ch = board[r][c];
			if (!node.Children.ContainsKey(ch))
			{
				return;
			}

			TrieNode currNode = node.Children[ch];

			if (currNode.Word != null)
			{
				result.Add(currNode.Word);
				currNode.Word = null;
			}

			board[r][c] = '#';

			int[] rowOffset = new int[] { -1, 1, 0, 0 };
			int[] colOffset = new int[] { 0, 0, -1, 1 };

			for (int i = 0; i < 4; i++)
			{
				int newRow = r + rowOffset[i];
				int newCol = c + colOffset[i];
				if (newRow >= 0 &&
					newRow < board.Length &&
					newCol >= 0 &&
					newCol < board[0].Length)
				{
					DFS(board, newRow, newCol, currNode, result);
				}
			}

			board[r][c] = ch;

			if (currNode.Children.Count == 0)
			{
				node.Children.Remove(ch);
			}
		}
	}
}
