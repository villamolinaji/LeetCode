namespace TopInterview150
{
	public class Solution109
	{
		public ListNode? SortList(ListNode? head)
		{
			if (head == null ||
				head.next == null)
			{
				return head;
			}

			var mid = GetMiddle(head);
			var left = head;
			var right = mid?.next;
			if (mid != null)
			{
				mid.next = null;
			}

			left = SortList(left);
			right = SortList(right);

			return Merge(left, right);
		}

		private ListNode? GetMiddle(ListNode head)
		{
			var slow = head;
			var fast = head.next;

			while (fast != null &&
				fast.next != null)
			{
				slow = slow?.next;
				fast = fast.next.next;
			}

			return slow;
		}

		private ListNode? Merge(ListNode? l1, ListNode? l2)
		{
			var dummy = new ListNode(0);
			var tail = dummy;

			while (l1 != null &&
				l2 != null)
			{
				if (l1.val < l2.val)
				{
					tail.next = l1;
					l1 = l1.next;
				}
				else
				{
					tail.next = l2;
					l2 = l2.next;
				}

				tail = tail.next;
			}

			if (l1 != null)
			{
				tail.next = l1;
			}
			else
			{
				tail.next = l2;
			}

			return dummy.next;
		}
	}
}
