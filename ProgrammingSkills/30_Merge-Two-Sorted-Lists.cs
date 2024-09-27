namespace ProgrammingSkills
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

	public class Solution30
	{
		public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
		{
			var val1 = list1?.val ?? int.MaxValue;
			var val2 = list2?.val ?? int.MaxValue;

			if (val1 <= val2 && list1 != null)
			{
				list1.next = MergeTwoLists(list1.next, list2);
				return list1;
			}
			else if (val1 > val2 && list2 != null)
			{
				list2.next = MergeTwoLists(list1, list2.next);
				return list2;
			}

			return null;
		}
	}
}
