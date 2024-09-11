namespace TopLiked100
{
	public class ListNode
	{
		public int val { get; set; }
		public ListNode? next { get; set; }
		public ListNode(int val = 0, ListNode? next = null)
		{
			this.val = val;
			this.next = next;
		}
	}

	public class Solution059
	{
		public ListNode? AddTwoNumbers(ListNode l1, ListNode l2)
		{
			var result = new ListNode(0);
			var nextL1 = l1;
			var nextL2 = l2;
			var current = result;
			var carry = 0;

			while (nextL1 != null ||
				nextL2 != null)
			{
				int val1 = (nextL1 != null) ? nextL1.val : 0;
				int val2 = (nextL2 != null) ? nextL2.val : 0;
				int sum = carry + val1 + val2;

				carry = sum / 10;

				current.next = new ListNode(sum % 10);
				current = current.next;

				if (nextL1 != null)
				{
					nextL1 = nextL1.next;
				}

				if (nextL2 != null)
				{
					nextL2 = nextL2.next;
				}
			}

			if (carry > 0)
			{
				current.next = new ListNode(carry);
			}

			return result.next;
		}
	}
}
