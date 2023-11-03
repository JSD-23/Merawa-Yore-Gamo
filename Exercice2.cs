using System;

class Exercice2
{
	public int MaxProfit(int[] prix, int prix_size) 
	{
	
		int max = 0;
		
		if (prix_size == 0)
			return  0;
		
		for (int i = 0; i < prix_size - 1; i++)
		{
			for (int j = i + 1; j < prix_size; j++)
			{
				if ((prix[j] - prix[i]) > max)
				{
					max = prix[j] - prix[i];
				}
			}
		}
		
		return max;
	}
}
