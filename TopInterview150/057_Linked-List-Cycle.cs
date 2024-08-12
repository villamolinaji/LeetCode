namespace TopInterview150
{
	public class ListNode
	{
		public int val { get; set; }

		public ListNode? next { get; set; }

		public ListNode(int x)
		{
			val = x;
			next = null;
		}
	}

	public class Solution057
	{
		public bool HasCycle(ListNode? head)
		{
			if (head == null || head.next == null)
			{
				return false;
			}

			var slow = head;
			var fast = head.next;

			while (slow != fast)
			{
				if (fast == null || fast.next == null)
				{
					return false;
				}
				slow = slow?.next;
				fast = fast.next.next;
			}

			return true;
		}
	}
}
