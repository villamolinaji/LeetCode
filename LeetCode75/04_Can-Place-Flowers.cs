namespace LeetCode75
{
	public class Solution04
	{
		public bool CanPlaceFlowers(int[] flowerbed, int n)
		{
			var subString = "000";
			var flowerbedString = String.Join("", flowerbed);

			int count = 0;
			int index = 0;

			if (flowerbedString.StartsWith("00"))
			{
				count++;				

				var stringArrayAux = flowerbedString.ToCharArray();
				stringArrayAux[0] = '1';
				flowerbedString = new string(stringArrayAux);
			}

			if (flowerbedString.EndsWith("00"))
			{
				count++;

				var stringArrayAux = flowerbedString.ToCharArray();
				stringArrayAux[flowerbedString.Length - 1] = '1';
				flowerbedString = new string(stringArrayAux);
			}

			index = flowerbedString.IndexOf(subString);
			while (index >= 0 && 
				count < n)
			{
				count++;
				index = index + 2;

				var stringArrayAux = flowerbedString.ToCharArray();
				stringArrayAux[index - 1] = '1';
				flowerbedString = new string(stringArrayAux);

				index = flowerbedString.IndexOf(subString, index);
			}

			if (flowerbedString == "0")
			{
				count++;
			}

			if (flowerbedString.StartsWith("001"))
			{
				count++;
			}

			if (flowerbedString.EndsWith("100"))
			{
				count++;
			}

			return count >= n;
		}
	}
}
