namespace TopInterview150
{
	public class Solution045
	{
		public bool IsHappy(int n)
		{
			HashSet<int> seen = new HashSet<int>();

			while (n != 1 &&
				!seen.Contains(n))
			{
				seen.Add(n);
				n = GetNext(n);
			}

			return n == 1;
		}

		private int GetNext(int n)
		{
			var nString = n.ToString();
			var newN = 0;

			foreach (var item in nString)
			{
				newN += (int)Math.Pow((int)char.GetNumericValue(item), 2);
			}

			return newN;
		}
	}
}
