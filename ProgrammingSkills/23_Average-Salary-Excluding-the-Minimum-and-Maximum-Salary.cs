namespace ProgrammingSkills
{
	public class Solution23
	{
		public double Average(int[] salary)
		{
			var minSalary = salary.Min();
			var maxSalary = salary.Max();
			var salaryCount = salary.Length - 2;
			var salarySum = salary.Sum() - minSalary - maxSalary;

			return salarySum / (double)salaryCount;
		}
	}
}
