namespace TopInterview150
{
	public class Solution062
	{
		public ListNode? ReverseKGroup(ListNode head, int k)
		{
			if (head == null ||
				k == 1)
			{
				return head;
			}

			var resultNode = new ListNode(0);
			resultNode.next = head;
			var prevNode = resultNode;

			while (true)
			{
				var kNode = GetKthNode(prevNode, k);
				if (kNode == null)
				{
					break;
				}

				var kNodeNext = kNode.next;
				var prev = kNode.next;
				var curr = prevNode?.next;

				while (curr != kNodeNext)
				{
					var next = curr?.next;
					if (curr != null)
					{
						curr.next = prev;
					}
					prev = curr;
					curr = next;
				}

				var tmp = prevNode?.next;
				if (prevNode != null)
				{
					prevNode.next = kNode;
					prevNode = tmp;
				}
			}

			return resultNode.next;
		}

		private ListNode? GetKthNode(ListNode? curr, int k)
		{
			while (curr != null &&
				k > 0)
			{
				curr = curr.next;
				k--;
			}

			return curr;
		}
	}
}
