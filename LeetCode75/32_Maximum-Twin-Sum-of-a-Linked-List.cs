namespace LeetCode75
{
	public class Solution32
	{
		public int PairSum(ListNode head)
		{
			if (head == null)
			{
				return 0;
			}

			var list = new List<int>();

			var current = head;
			list.Add(current.val);

			while (current.next != null)
			{
				current = current.next;

				list.Add(current.val);
			}

			int maxSum = int.MinValue;

			for (int i = 0; i < list.Count / 2; i++)
			{
				int a = list[i];
				int b = list[list.Count - 1 - i];

				int sum = a + b;

				maxSum = Math.Max(maxSum, sum);
			}

			return maxSum;
		}
	}
}
