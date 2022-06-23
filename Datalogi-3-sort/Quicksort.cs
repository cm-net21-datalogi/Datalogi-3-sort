using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogi_3_sort
{
	public class Quicksort
	{
		public static void Sort(int[] array)
		{
			SortPart(array, 0, array.Length - 1);
		}
		private static void SortBuggy(int[] array, int low, int high)
		{
			// välj ett pivot-element - första i arrayen
			// loopvariabler för index
			// loopa tills indexen möts
			// är både left och right på fel plats? -> byt plats
			// är left på rätt plats? -> gå till nästa index
			// är right på rätt plats? -> gå till nästa index
			// efter lopen: swappa in pivot-elementet
			// sortera vänster och höger del separat

			// basfall: denna del är redan sorterad
			if (high <= low)
				return;

			int pivot = low;
			int leftIndex = low + 1, rightIndex = high;
			while (leftIndex < rightIndex)  // n - går igenom hela arrayen
			{
				// Är vänstra värdet på rätt plats?
				if (array[leftIndex] <= array[pivot])
					leftIndex++;

				// Är högra värdet på rätt plats?
				if (array[rightIndex] >= array[pivot])
					rightIndex--;

				// Är båda på fel plats?
				if (array[leftIndex] > array[pivot] && array[rightIndex] < array[pivot])
				{
					int temp = array[leftIndex];
					array[leftIndex] = array[rightIndex];
					array[rightIndex] = temp;
					//leftIndex++;
					//rightIndex--;
				}
			}
			// vilka värden har leftIndex och rightIndex nu?
			// L <= P, R <= P  -> sätt in till höger
			// L <= P, R > P  --> sätt in mittemellan
			// L > P, R > P   --> sätt in till vänster
			if (leftIndex > rightIndex)
			{
				int temp = leftIndex;
				leftIndex = rightIndex;
				rightIndex = temp;
			}

			// swappa in pivot-elementet
			if (array[rightIndex] <= array[pivot] && array[leftIndex] <= array[pivot])
			{
				int temp = array[rightIndex];
				array[rightIndex] = array[pivot];
				array[pivot] = temp;
				pivot = rightIndex;
			}
			else if(array[rightIndex] > array[pivot] && array[leftIndex] > array[pivot])
			{
				int temp = array[leftIndex - 1];
				array[leftIndex - 1] = array[pivot];
				array[pivot] = temp;
				pivot = leftIndex - 1;
			}
			else
			{
				int temp = array[leftIndex];
				array[leftIndex] = array[pivot];
				array[pivot] = temp;
			}
			SortPart(array, low, pivot - 1);
			SortPart(array, pivot + 1, high);
		}
		private static void SortPart(int[] array, int low, int high)
		{
			if (high - low == 1)
			{
				if (array[high] < array[low])
					swap(array, high, low);
				return;
			}
			else if (high - low < 2) return;

			int pivotIndex = (low + high) / 2;
			int pivot = array[pivotIndex];
			int left = low;
			int right = high;

			while (left < right)
			{
				// hitta nästa element till vänster, som behöver swappas
				while (array[left] < pivot && left < right) left++;

				// hitta nästa element till höger, som behöver swappas
				while (array[right] > pivot && left < right) right--;

				if (left >= right) break;
				//if (left < right)
					swap(array, left, right);
			}

			SortPart(array, low, right);
			SortPart(array, right + 1, high);
		}
		private static void swap(int[] array, int x, int y)
		{
			int temp = array[x];
			array[x] = array[y];
			array[y] = temp;
		}
	}
}
