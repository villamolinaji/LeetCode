namespace TopInterview150
{
	public class Solution095
	{
		public int SnakesAndLadders(int[][] board)
		{
			var boardLength = board.Length;
			var moves = new int[boardLength * boardLength + 1];
			Array.Fill(moves, -1);
			var index = 1;
			var leftToRight = true;

			for (int r = boardLength - 1; r >= 0; r--)
			{
				if (leftToRight)
				{
					for (int c = 0; c < boardLength; c++)
					{
						if (board[r][c] != -1)
						{
							moves[index] = board[r][c];
						}

						index++;
					}
				}
				else
				{
					for (int c = boardLength - 1; c >= 0; c--)
					{
						if (board[r][c] != -1)
						{
							moves[index] = board[r][c];
						}

						index++;
					}
				}

				leftToRight = !leftToRight;
			}

			var queue = new Queue<int>();
			queue.Enqueue(1);
			var visited = new bool[boardLength * boardLength + 1];
			visited[1] = true;
			var steps = 0;

			while (queue.Count > 0)
			{
				var queueLength = queue.Count;

				for (int i = 0; i < queueLength; i++)
				{
					var current = queue.Dequeue();

					if (current == boardLength * boardLength)
					{
						return steps;
					}

					for (int j = 1; j <= 6 && current + j <= boardLength * boardLength; j++)
					{
						var next = current + j;

						if (moves[next] != -1)
						{
							next = moves[next];
						}

						if (!visited[next])
						{
							visited[next] = true;
							queue.Enqueue(next);
						}
					}
				}

				steps++;
			}

			return -1;
		}
	}
}
