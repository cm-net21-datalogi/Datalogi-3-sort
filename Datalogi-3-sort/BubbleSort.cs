using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogi_3_sort
{
	public class BubbleSort
	{
		public static int[] Sort(int[] oldArray)
		{
			// Börja från första elementet.
			// Från första till sista osorterade* elementet i listan:
			// Jämför med nästa element. Är de i rätt ordning? I så fall, gå vidare.
			// Om de inte är i rätt ordning, byt plats.
			// Gå vidare till nästa element.
			// När du når slutet på listan, är sista elementet garanterat på rätt plats. Börja om från början.
			// Upprepa tills alla element är sorterade.
			int[] array = oldArray.ToArray(); // n
			
			for(int j=0; j<array.Length; j++)  // n
			{
				for(int i=0; i< array.Length - 1; i++)  // n-1
				{
					// Om två element kommer i fel ordning, byt plats på dem
					if (array[i] > array[i + 1])  // 1
					{
						int temp = array[i];  // 1
						array[i] = array[i + 1];  // 1
						array[i + 1] = temp;  // 1
					}
					// sammanlagt 1-4
				}
			}
			return array;
			// Tidskomplexitet: n + n * (n-1) * 4
			// == n + 4 * n^2 - 4*n == 4*n^2 + n - 4*n
			// --> O(n^2)
		}
	}
}
