namespace ProgrammingSkills
{
	public class Solution33
	{
		public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
		{
			l1 = ReverseList(l1);
			l2 = ReverseList(l2);

			ListNode? result = AddTwoLists(l1, l2);

			return ReverseList(result);
		}

		private static ListNode? ReverseList(ListNode? head)
		{
			ListNode? prev = null;
			ListNode? current = head;

			while (current != null)
			{
				ListNode? nextNode = current.next;
				current.next = prev;
				prev = current;
				current = nextNode;
			}

			return prev;
		}

		private static ListNode? AddTwoLists(ListNode? l1, ListNode? l2)
		{
			ListNode dummyHead = new ListNode(0);
			ListNode current = dummyHead;
			int carry = 0;

			while (l1 != null ||
				l2 != null ||
				carry > 0)
			{
				int sum = carry;

				if (l1 != null)
				{
					sum += l1.val;
					l1 = l1.next;
				}

				if (l2 != null)
				{
					sum += l2.val;
					l2 = l2.next;
				}

				carry = sum / 10;

				current.next = new ListNode(sum % 10);
				current = current.next;
			}

			return dummyHead.next;
		}
	}
}
