namespace TopInterview150_091
{
	public class Node
	{
		public int val { get; set; }
		public IList<Node?> neighbors { get; set; }

		public Node()
		{
			val = 0;
			neighbors = new List<Node?>();
		}

		public Node(int _val)
		{
			val = _val;
			neighbors = new List<Node?>();
		}

		public Node(int _val, List<Node?> _neighbors)
		{
			val = _val;
			neighbors = _neighbors;
		}
	}

	public class Solution091
	{
		private Dictionary<Node, Node> visited { get; set; } = new Dictionary<Node, Node>();

		public Node? CloneGraph(Node? node)
		{
			if (node == null)
			{
				return null;
			}

			if (visited.ContainsKey(node))
			{
				return visited[node];
			}

			var cloneNode = new Node(node.val, new List<Node?>());
			visited[node] = cloneNode;

			foreach (var neighbor in node.neighbors)
			{
				cloneNode.neighbors.Add(CloneGraph(neighbor));
			}

			return cloneNode;
		}
	}
}
