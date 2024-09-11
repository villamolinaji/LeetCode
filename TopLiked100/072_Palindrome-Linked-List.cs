using System.Text;

namespace TopLiked100
{
	public class Solution072
	{
		public bool IsPalindrome(ListNode head)
		{
			var sbList = new StringBuilder();

			var current = head;
			while (current != null)
			{
				sbList.Append(current.val);
				current = current.next;
			}

			var sbListReversed = sbList.ToString().Reverse();

			return sbListReversed.SequenceEqual(sbList.ToString());
		}
	}
}
