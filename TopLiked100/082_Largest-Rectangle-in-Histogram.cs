namespace TopLiked100
{
	public class Solution082
	{
		public int LargestRectangleArea(int[] heights)
		{
			var stack = new Stack<int>();
			var maxArea = 0;
			var heightsLength = heights.Length;

			for (int i = 0; i < heightsLength; i++)
			{
				while (stack.Count > 0 &&
					heights[i] < heights[stack.Peek()])
				{
					maxArea = MaxArea(maxArea, stack, heights, i);
				}

				stack.Push(i);
			}

			while (stack.Count > 0)
			{
				maxArea = MaxArea(maxArea, stack, heights, heightsLength);
			}

			return maxArea;
		}

		private int MaxArea(int maxArea, Stack<int> stack, int[] heights, int index)
		{
			var height = heights[stack.Pop()];
			var width = stack.Count == 0
				? index
				: index - stack.Peek() - 1;

			return Math.Max(maxArea, height * width);
		}
	}
}
