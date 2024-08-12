namespace TopInterview150
{
	public class MinStack
	{
		public Stack<int> MyStack { get; set; }
		public Stack<int> MinValueStack { get; set; }

		public MinStack()
		{
			MyStack = new Stack<int>();
			MinValueStack = new Stack<int>();
		}

		public void Push(int val)
		{
			MyStack.Push(val);
			if (MinValueStack.Count == 0 ||
				val <= MinValueStack.Peek())
			{
				MinValueStack.Push(val);
			}

		}

		public void Pop()
		{
			if (MyStack.Peek() == MinValueStack.Peek())
			{
				MinValueStack.Pop();
			}

			MyStack.Pop();
		}

		public int Top()
		{
			return MyStack.Peek();
		}

		public int GetMin()
		{
			return MinValueStack.Peek();
		}
	}
}
