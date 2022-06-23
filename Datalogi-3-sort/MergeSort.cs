using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogi_3_sort
{
	public class MergeSort
	{
		public static int[] Sort(int[] array)
		{
			// Om listan är tilräckligt liten och sorterad, avsluta
			// Annars: dela listan på mitten och sortera varje del för sig
			// Kombinera de båda sorterade listorna

			if (array.Length == 1)  // 1
			{
				return array;
			}
			// [10, 11, 12, 13, 14]
			int[] first = new int[array.Length / 2];  // n/2
			int[] second = new int[array.Length - first.Length]; // n/2
			for(int i=0; i<first.Length; i++)  // n/2
			{
				first[i] = array[i];
			}
			for(int i=0; i<second.Length; i++)  // n/2
			{
				second[i] = array[first.Length + i];
			}
			first = Sort(first);  // n * log(n)
			second = Sort(second);  // n * log(n)
			return Merge(first, second);  // n/2 + n/2 --> O(n)
			// Sammanlagt: O(n * log(n))
		}
		public static int[] Merge(int[] first, int[] second)
		{
			// skapa en ny array för att spara den kombinerade datan
			// skapa variabler för index
			// loopa
			// Tidskomplexitet: m+n + 3 + (m+n)*4 == (m+n)*5 + 3
			// --> O(m + n)

			int[] merged = new int[first.Length + second.Length]; //m+n
			int firstIndex = 0, secondIndex = 0, mergedIndex = 0; // 3
			while(firstIndex < first.Length || secondIndex < second.Length)  // m+n
			{
				if (firstIndex >= first.Length)
				{
					merged[mergedIndex++] = second[secondIndex++];
				}
				else if(secondIndex>= second.Length)
				{
					merged[mergedIndex++] = first[firstIndex++];
				}
				else
				{
					if (first[firstIndex] < second[secondIndex])
					{
						merged[mergedIndex++] = first[firstIndex++];
					}
					else
					{
						merged[mergedIndex++] = second[secondIndex++];
					}
				}
			}
			return merged;
		}//Merge
	}
}
