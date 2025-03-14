namespace Assignment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Test Assignment Push");


			List<Book> books = new List<Book>
			{
			new Book("978-3-16-148410-0", "C# Basics", new string[] { "John Doe", "Jane Doe" }, new DateTime(2021, 5, 10), 29.99m),
			new Book("978-1-23-456789-7", "Advanced C#", new string[] { "Mark Smith" }, new DateTime(2020, 8, 15), 49.99m),
			new Book("978-0-12-345678-9", "Design Patterns", new string[] { "Erich Gamma", "Richard Helm" }, new DateTime(2019, 3, 22), 59.99m)
			};

			#region With use define delegate
			//// Title
			//Console.WriteLine("\nBook Titles:");
			//LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

			//// Authors
			//Console.WriteLine("\nBook Authors:");
			//LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

			//// Price
			//Console.WriteLine("\nBook Prices:");
			//LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice); 
			#endregion

			#region With Built in delegate
			// Title
			Console.WriteLine("\nBook Titles:");
			LibraryEngine.ProcessBooksBuiltInDelegate(books, BookFunctions.GetTitle);

			// Authors
			Console.WriteLine("\nBook Authors:");
			LibraryEngine.ProcessBooksBuiltInDelegate(books, BookFunctions.GetAuthors);

			// Price
			Console.WriteLine("\nBook Prices:");
			LibraryEngine.ProcessBooksBuiltInDelegate(books, BookFunctions.GetPrice);
			#endregion
		}
	}
}
