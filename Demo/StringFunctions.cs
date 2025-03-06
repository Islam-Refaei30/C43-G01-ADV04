using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	// 0 : Delegate Declaration
	public delegate int StringFuncDelegate(string s);
	//1-new Delegate (Class), the ref from this Delegate can refere to Function or more than function [Pointer to function]
	//2-these function may be class member function or object member function
	//3-these function must be the same signature of the delegate
	//4-reraldless function access modifer or name of the function

	internal class StringFunctions
	{
		public static int GetCountOfUpperChars(string Name)
		{
			int count = 0;
			if (Name is not null)
			{
				for (int i = 0; i < Name.Length; i++)
				{
					if (char.IsUpper(Name[i]))
						count++;
				}
			}
			return count;
		}

		public static int GetCountOfLowerChars(string Name)
		{
			int count = 0;
			if (Name is not null)
			{
				for (int i = 0; i < Name.Length; i++)
				{
					if (char.IsLower(Name[i]))
						count++;
				}
			}
			return count;
		}
	}
}
