namespace ProgrammingSkills
{
	public class Solution15
	{
		public bool JudgeCircle(string moves)
		{

			var x = 0;
			var y = 0;

			foreach (var move in moves)
			{
				switch (move)
				{
					case 'U':
						y++;
						break;
					case 'D':
						y--;
						break;
					case 'L':
						x--;
						break;
					case 'R':
						x++;
						break;
				}
			}

			return x == 0 &&
				y == 0;

#pragma warning disable S125 // Sections of code should not be commented out
			/*
			var countU = moves.Count(c => c == 'U');
			var countD = moves.Count(c => c == 'D');

			if (countU != countD)
			{
				return false;
			}

			var countL = moves.Count(c => c == 'L');
			var countR = moves.Count(c => c == 'R');

			return countL == countR;	
			*/
		}
#pragma warning restore S125 // Sections of code should not be commented out
	}
}
