namespace ProgrammingSkills
{
	public class Solution17
	{
		public bool IsRobotBounded(string instructions)
		{
			int[,] directions = new int[,]
			{
				{ 0, 1 },
				{ 1, 0 },
				{ 0, -1 },
				{ -1, 0 }
			};

			int x = 0;
			int y = 0;
			int dir = 0;

			foreach (char instruction in instructions)
			{
				if (instruction == 'G')
				{
					x += directions[dir, 0];
					y += directions[dir, 1];
				}
				else if (instruction == 'L')
				{
					dir = (dir + 3) % 4;
				}
				else if (instruction == 'R')
				{
					dir = (dir + 1) % 4;
				}
			}

			return (x == 0 && y == 0) ||
				(dir != 0);
		}
	}
}
