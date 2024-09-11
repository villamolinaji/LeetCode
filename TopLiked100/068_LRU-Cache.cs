namespace TopLiked100
{
	public class LruCache
	{

		private sealed class Node
		{
			public int Key;
			public int Value;
			public Node? Prev;
			public Node? Next;
			public Node(int key, int value)
			{
				this.Key = key;
				this.Value = value;
			}
		}

		private Dictionary<int, Node> CacheDictionary { get; set; }
		private int Capacity { get; set; }
		private Node Head { get; set; }
		private Node Tail { get; set; }

		public LruCache(int capacity)
		{
			this.Capacity = capacity;
			this.CacheDictionary = new Dictionary<int, Node>(capacity);

			Head = new Node(0, 0);
			Tail = new Node(0, 0);
			Head.Next = Tail;
			Tail.Prev = Head;
		}

		public int Get(int key)
		{
			if (CacheDictionary.ContainsKey(key))
			{
				var node = CacheDictionary[key];

				MoveToHead(node);

				return node.Value;
			}
			else
			{
				return -1;
			}
		}

		public void Put(int key, int value)
		{
			if (CacheDictionary.ContainsKey(key))
			{
				var node = CacheDictionary[key];
				node.Value = value;

				MoveToHead(node);
			}
			else
			{
				var newNode = new Node(key, value);
				CacheDictionary[key] = newNode;

				AddToHead(newNode);

				if (CacheDictionary.Count > Capacity)
				{
					var tailNode = RemoveTail();
					if (tailNode != null)
					{
						CacheDictionary.Remove(tailNode.Key);
					}
				}
			}
		}

		private void AddToHead(Node node)
		{
			node.Prev = Head;
			node.Next = Head.Next;

			if (Head.Next != null)
			{
				Head.Next.Prev = node;
			}
			Head.Next = node;
		}

		private void RemoveNode(Node? node)
		{
			var prev = node?.Prev;
			var next = node?.Next;

			if (prev != null)
			{
				prev.Next = next;
			}
			if (next != null)
			{
				next.Prev = prev;
			}
		}

		private void MoveToHead(Node node)
		{
			RemoveNode(node);
			AddToHead(node);
		}

		private Node? RemoveTail()
		{
			var tailPrev = Tail.Prev;
			RemoveNode(tailPrev);
			return tailPrev;
		}
	}
}
