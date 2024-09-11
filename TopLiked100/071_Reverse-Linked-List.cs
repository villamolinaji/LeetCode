namespace TopLiked100
{
	public class Solution071
	{
		public ListNode? ReverseList(ListNode head)
		{
			if (head == null)
			{
				return null;
			}

			var stackList = new Stack<int>();

			var current = head;
			stackList.Push(current.val);

			while (current.next != null)
			{
				current = current.next;

				stackList.Push(current.val);
			}

			var currentValue = stackList.Pop();
			var returnLisNode = new ListNode(currentValue);
			current = returnLisNode;

			while (stackList.Count > 0)
			{
				current.next = new ListNode(stackList.Pop());
				current = current.next;
			}

			return returnLisNode;
		}
	}
}
