namespace TopInterview150_110
{
	public class Node
	{
		public bool val { get; set; }
		public bool isLeaf { get; set; }
		public Node? topLeft { get; set; }
		public Node? topRight { get; set; }
		public Node? bottomLeft { get; set; }
		public Node? bottomRight { get; set; }

		public Node()
		{
			val = false;
			isLeaf = false;
			topLeft = null;
			topRight = null;
			bottomLeft = null;
			bottomRight = null;
		}

		public Node(bool _val, bool _isLeaf)
		{
			val = _val;
			isLeaf = _isLeaf;
			topLeft = null;
			topRight = null;
			bottomLeft = null;
			bottomRight = null;
		}

		public Node(bool _val, bool _isLeaf, Node _topLeft, Node _topRight, Node _bottomLeft, Node _bottomRight)
		{
			val = _val;
			isLeaf = _isLeaf;
			topLeft = _topLeft;
			topRight = _topRight;
			bottomLeft = _bottomLeft;
			bottomRight = _bottomRight;
		}
	}

	public class Solution110
	{
		public Node Construct(int[][] grid)
		{
			return ConstructQuadTree(grid, 0, 0, grid.Length);
		}

		private Node ConstructQuadTree(int[][] grid, int row, int col, int size)
		{
			if (size == 1)
			{
				return new Node(grid[row][col] == 1, true);
			}

			var newSize = size / 2;
			var nodeTopLeft = ConstructQuadTree(grid, row, col, newSize);
			var nodeTopRight = ConstructQuadTree(grid, row, col + newSize, newSize);
			var nodeBottomLeft = ConstructQuadTree(grid, row + newSize, col, newSize);
			var nodeBottomRight = ConstructQuadTree(grid, row + newSize, col + newSize, newSize);

			if (nodeTopLeft.isLeaf &&
				nodeTopRight.isLeaf &&
				nodeBottomLeft.isLeaf &&
				nodeBottomRight.isLeaf &&
				nodeTopLeft.val == nodeTopRight.val &&
				nodeTopRight.val == nodeBottomLeft.val &&
				nodeBottomLeft.val == nodeBottomRight.val)
			{
				return new Node(nodeTopLeft.val, true);
			}
			else
			{
				return new Node(false, false, nodeTopLeft, nodeTopRight, nodeBottomLeft, nodeBottomRight);
			}
		}
	}
}
