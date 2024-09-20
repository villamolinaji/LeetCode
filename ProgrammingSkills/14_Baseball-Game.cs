namespace ProgrammingSkills
{
	public class Solution14
	{
		public int CalPoints(string[] operations)
		{
			var scores = new List<int>();

			foreach (var op in operations)
			{
				if (op == "C")
				{
					scores.RemoveAt(scores.Count - 1);
				}
				else if (op == "D")
				{
					scores.Add(scores[scores.Count - 1] * 2);
				}
				else if (op == "+")
				{
					scores.Add(scores[scores.Count - 1] + scores[scores.Count - 2]);
				}
				else
				{
					scores.Add(int.Parse(op));
				}
			}

			return scores.Sum();
		}
	}
}
