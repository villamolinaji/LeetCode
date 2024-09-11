namespace TopLiked100
{
	public class Node
	{
		public int val { get; set; }
		public Node? next { get; set; }
		public Node? random { get; set; }

		public Node(int _val)
		{
			val = _val;
			next = null;
			random = null;
		}
	}

	public class Solution065
	{
		public Node? CopyRandomList(Node? head)
		{
			if (head == null)
			{
				return null;
			}

			var current = head;
			while (current != null)
			{
				Node newNode = new Node(current.val);
				newNode.next = current.next;
				current.next = newNode;
				current = newNode.next;
			}

			current = head;
			while (current != null)
			{
				if (current.random != null &&
					current.next != null)
				{
					current.next.random = current.random.next;
				}

				current = current.next?.next;
			}

			current = head;
			var copiedHead = head.next;
			var copy = copiedHead;

			while (current != null)
			{
				current.next = current.next?.next;

				if (copy?.next != null)
				{
					copy.next = copy.next.next;
				}

				current = current.next;
				copy = copy?.next;
			}

			return copiedHead;
		}
	}
}
