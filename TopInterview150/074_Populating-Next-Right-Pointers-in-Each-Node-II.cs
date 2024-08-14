namespace TopInterview150
{
	public class Node
	{
		public int val { get; set; }

		public Node? left { get; set; }

		public Node? right { get; set; }

		public Node? next { get; set; }

		public Node(int _val)
		{
			val = _val;
			left = null;
			right = null;
			next = null;
		}

		public Node(int _val, Node _left, Node _right, Node _next)
		{
			val = _val;
			left = _left;
			right = _right;
			next = _next;
		}
	}

	public class Solution074
	{
		public Node? Connect(Node root)
		{
			if (root == null)
			{
				return null;
			}

			var auxNode = new Node(0);
			var currentNode = auxNode;
			var head = root;

			while (head != null)
			{
				while (head != null)
				{
					if (head.left != null)
					{
						currentNode.next = head.left;
						currentNode = currentNode.next;
					}

					if (head.right != null)
					{
						currentNode.next = head.right;
						currentNode = currentNode.next;
					}

					head = head.next;
				}

				head = auxNode.next;
				auxNode.next = null;
				currentNode = auxNode;
			}

			return root;
		}
	}
}
