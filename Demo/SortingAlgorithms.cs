using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	public delegate bool SotringTypesFuncDelegate(int array01, int array02);
	internal class SortingAlgorithms
	{
		#region Without Generics
		#region Part 01
		//public static void BubbleSortAsc(int[] Array)
		//{
		//	if (Array is not null)
		//	{
		//		for (int i = 0; i < Array.Length; i++)
		//		{
		//			for (int j = 0; j < Array.Length - i - 1; j++)
		//			{
		//				if (Array[j] > Array[j + 1])
		//					Swap(ref Array[j], ref Array[j + 1]);

		//			}
		//		}
		//	}
		//}

		//public static void BubbleSortDesc(int[] Array)
		//{
		//	if (Array is not null)
		//	{
		//		for (int i = 0; i < Array.Length; i++)
		//		{
		//			for (int j = 0; j < Array.Length - i - 1; j++)
		//			{
		//				if (Array[j] < Array[j + 1])
		//					Swap(ref Array[j], ref Array[j + 1]);

		//			}
		//		}
		//	}
		//}  
		#endregion

		#region Part 02
		public static void BubbleSort(int[] Array, SotringTypesFuncDelegate sotringTypesFunc)
		{
			if (Array is not null && sotringTypesFunc is not null)
			{
				for (int i = 0; i < Array.Length; i++)
				{
					for (int j = 0; j < Array.Length - i - 1; j++)
					{
						//if (Array[j] > Array[j + 1])
						if (sotringTypesFunc.Invoke(Array[j], Array[j + 1]))
							Swap(ref Array[j], ref Array[j + 1]);

					}
				}
			}
		}
		#endregion
		#endregion

		#region With Generics


		#endregion

		#region Swap Function
		private static void Swap(ref int x, ref int y)
		{
			int temp = x; x = y; y = temp;
		} 
		#endregion
	}
}
