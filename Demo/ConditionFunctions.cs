using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	internal class ConditionFunctions
	{
		public static bool CheckOdd(int Number)
		{
			return Number % 2 == 1;
		}

		public static bool CheckEven(int Number)
		{
			return Number % 2 == 0;
		}
	}
}
