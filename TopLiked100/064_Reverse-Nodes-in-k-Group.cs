namespace TopLiked100
{
	public class Solution064
	{
		public ListNode? ReverseKGroup(ListNode head, int k)
		{
			if (head == null ||
				k == 1)
			{
				return head;
			}

			var auxNode = new ListNode(0);
			auxNode.next = head;
			var groupPrev = auxNode;

			while (true)
			{
				var kNode = GetKthNode(groupPrev, k);
				if (kNode == null)
				{
					break;
				}

				var groupNext = kNode.next;
				var prev = kNode.next;
				var curr = groupPrev?.next;

				while (curr != groupNext)
				{
					var next = curr?.next;
					if (curr != null)
					{
						curr.next = prev;
					}
					prev = curr;
					curr = next;
				}

				var tmp = groupPrev?.next;
				if (groupPrev != null)
				{
					groupPrev.next = kNode;
					groupPrev = tmp;
				}
			}

			return auxNode.next;
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
