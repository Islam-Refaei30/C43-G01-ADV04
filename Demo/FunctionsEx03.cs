using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	public delegate bool ConditionFunCDelegale(int Number);
	internal class FunctionsEx03
	{
		public static List<int> OddNumber(List<int> list)
		{
			List<int> result = new List<int>();

			if (list is not null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i]%2 == 1)
						result.Add(list[i]);
				}
			}
			return result;
		}

		public static List<int> EvenNumber(List<int> list)
		{
			List<int> result = new List<int>();

			if (list is not null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] % 2 == 0)
						result.Add(list[i]);
				}
			}
			return result;
		}

		public static List<int> NumberDivisibleBy7(List<int> list)
		{
			List<int> result = new List<int>();

			if (list is not null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] % 7 == 0)
						result.Add(list[i]);
				}
			}
			return result;
		}

		public static List<int> NumberDivisibleBy10(List<int> list)
		{
			List<int> result = new List<int>();

			if (list is not null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] % 10 == 0)
						result.Add(list[i]);
				}
			}
			return result;
		}


		public static List<int> FindNumbeers(List<int> list, ConditionFunCDelegale Condition)
		{
			List<int> result = new List<int>();

			if (list is not null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					//if (list[i] % 10 == 0)
					if (Condition.Invoke(list[i]))
						result.Add(list[i]);
				}
			}
			return result;
		}
	}
}
