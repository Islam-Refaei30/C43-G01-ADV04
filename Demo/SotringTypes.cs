using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	internal class SotringTypes
	{
		public static bool SortingStringAsc(string Name01, string Name02)
		{
			return Name01?.Length > Name02?.Length;
		}
		public static bool SortingStringDesc(string Name01, string Name02)
		{
			return Name01?.Length < Name02?.Length;
		}

		public static bool ComperGrt(int X, int Y)
		{
			return X > Y; // Sort Asc
		}		
		public static bool ComperLess(int X, int Y)
		{
			return X < Y; // Sort Desc
		}
	}
}
