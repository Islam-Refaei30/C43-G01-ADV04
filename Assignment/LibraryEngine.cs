using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
	public delegate T FPTR<T>(Book B);
	internal class LibraryEngine
	{
		public static void ProcessBooks<T> (List<Book> BList, FPTR<T> ftr)
		{
			foreach (Book book in BList)
			{
				Console.WriteLine(ftr(book));
			}
		}

		public static void ProcessBooksBuiltInDelegate<T>(List<Book> BList, Func<Book, T> func)
		{
			foreach (Book book in BList)
			{
				Console.WriteLine(func(book));
			}
		}
	}
}
