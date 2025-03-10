using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	public delegate bool SotringTypesFuncDelegate<T01, T02>(T01 array01, T02 array02);
	//public delegate TResult SotringTypesFuncDelegate<in T01, in T02, out TResult>(T01 array01, T02 array02);
	internal class SortingAlgorithms<T>
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
		//public static void BubbleSort(int[] Array, SotringTypesFuncDelegate sotringTypesFunc)
		//{
		//	if (Array is not null && sotringTypesFunc is not null)
		//	{
		//		for (int i = 0; i < Array.Length; i++)
		//		{
		//			for (int j = 0; j < Array.Length - i - 1; j++)
		//			{
		//				//if (Array[j] > Array[j + 1])
		//				if (sotringTypesFunc.Invoke(Array[j], Array[j + 1]))
		//					Swap(ref Array[j], ref Array[j + 1]);

		//			}
		//		}
		//	}
		//}
		#endregion
		#endregion

		#region With Generics

		public static void BubbleSort(T[] Array, SotringTypesFuncDelegate<T,T> sotringTypesFunc)
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

		#region Swap Function
		private static void Swap(ref T  x, ref T y)
		{
			T temp = x; x = y; y = temp;
		} 
		#endregion
	}
}
