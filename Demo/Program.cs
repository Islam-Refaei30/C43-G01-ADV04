namespace Demo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Test Demo Push");
			#region Part 01 Intro To Delegate &Example 01
			//int Result = StringFunctions.GetCountOfUpperChars();

			////Step 1 : Declare ref from delegate
			//StringFuncDelegate Ref;

			////Step 2 : initialize ref from delegate [Point to Function]
			////Ref = new StringFuncDelegate(StringFunctions.GetCountOfUpperChars);
			//Ref = StringFunctions.GetCountOfUpperChars; //sentex Suger
			////Ref += StringFunctions.GetCountOfLowerChars;

			//   //Step 3: Use Delegate Reference [Call Method]
			//int Result = Ref.Invoke("IsLAm");
			//Console.WriteLine(Result);
			#endregion

			#region Part 02 Delegate Example 02 [With out Generics]
			#region Without Generics
			//int[] Numbers = { 5, 5, 10, 6, 8, 200, 34 };
			////SortingAlgorithms.BubbleSortAsc(Numbers);
			////SortingAlgorithms.BubbleSortDesc(Numbers);
			//SotringTypesFuncDelegate SortingTypr = SotringTypes.ComperGrt;
			////SotringTypesFuncDelegate SortingTypr = default;
			//SortingAlgorithms.BubbleSort(Numbers, SortingTypr);
			//foreach (int number in Numbers)
			//{
			//	Console.WriteLine(number);
			//}

			#endregion

			#region With Generics
			#region EX 01
			//string[] Names = { "Ali", "Omar", "Rana", "islam", "Zoz" };
			////SotringTypesFuncDelegate<string, string> sortingType = SotringTypes.SortingStringAsc;
			//Func<string, string, bool> sortingType = SotringTypes.SortingStringAsc;
			//SortingAlgorithms<string>.BubbleSort(Names, sortingType);
			////SortingAlgorithms<string>.BubbleSort(Names, SotringTypes.SortingStringAsc);
			//foreach (string name in Names)
			//{
			//	Console.WriteLine(name);
			//}
			#endregion
			#endregion
			#endregion

			#region Part 04 Delegate Example 03 [With out Generics]

			#region Without Generics
			#region EX 01
			//List<int> numbers = Enumerable.Range(0,100).ToList(); 
			////List<int> OddNums = FunctionsEx03.OddNumber(numbers);
			//List<int> EvenNums = FunctionsEx03.EvenNumber(numbers);
			////List<int> NumsDivisible7 = FunctionsEx03.NumberDivisibleBy7(numbers);
			////List<int> NumsDivisible10 = FunctionsEx03.NumberDivisibleBy10(numbers);
			//foreach (int num in EvenNums)
			//{
			//	Console.WriteLine(num);
			//} 
			#endregion
			#region EX02
			//List<int> numbers = Enumerable.Range(0, 100).ToList();
			//List<int> OddNums = FunctionsEx03<int>.FindElement(numbers, ConditionFunctions.CheckOdd);
			//List<int> EvenNumbers = FunctionsEx03<int>.FindElement(numbers, ConditionFunctions.CheckEven);
			//foreach (int num in OddNums)
			//{
			//	Console.WriteLine(num);
			//}

			//Console.WriteLine("---------------------------EVEN-------------------------");

			//foreach (int num in EvenNumbers)
			//{
			//	Console.WriteLine(num);
			//}
			#endregion
			#endregion
			#endregion

			#region Part 05 Delegate Example 03 [With Generics]
			#region With Generics
			//List<string> Names02=new List<string> { "Islam", "Zoz", "Rana", "ali" };
			//List<string> NewL = new List<string>();
			//NewL = FunctionsEx03<string>.FindElement(Names02,ConditionFunctions.StringLessThan4);
			//foreach (string s in NewL)
			//{
			//	Console.WriteLine(s);
			//}
			#endregion
			#endregion

			#region Part 06 Built In Delegate [Func- Predicate- Action]
			#region Examples On Built in Delegate

			#region Predicate
			//Predicate<int> predicate = SomeFunctionForTest.test;
			//predicate.Invoke(10);
			#endregion

			#region Func
			//Func<int,string> Func = SomeFunctionForTest.Cast;
			//Func.Invoke(10);
			//Func(15);
			#endregion

			#region Action
			//Action<string> action = SomeFunctionForTest.Print;
			//action("islam");
			#endregion

			#endregion
			#endregion

			#region Part 08 Anonymous Method and Lambada Expression
			#region Anonymous Function
			#region Predicate
			//Predicate<int> predicate = delegate (int Numbeer) { return Numbeer > 0; };
			//predicate.Invoke(50);
			//predicate(10);
			#endregion

			#region Func
			//Func<int, string> Func = delegate (int Number) { return Number.ToString(); };
			//Func.Invoke(10);
			//Func(15);
			#endregion

			#region Action
			//Action<string> action = delegate (string Name) { Console.WriteLine($"Name is : {Name}"); };
			//action("islam");
			#endregion
			#endregion

			#region Lambada Expression
			#region Predicate
			//Predicate<int> predicate = Numbeer => Numbeer > 0;
			//predicate.Invoke(50);
			//predicate(10);
			#endregion

			#region Func
			//Func<int, string> Func = Name => Name.ToString();  
			//Func.Invoke(10);
			//Func(15);
			#endregion

			#region Action
			//Action<string> action = Name => Console.WriteLine($"Name is : {Name}");
			//action("islam");
			#endregion
			#endregion
			#endregion

			#region Part 09 New Feature at Delegate in C# 10
			#region Predicate
			var predicate = (int Numbeer ) => Numbeer > 0;
			//Predicate<int> predicate = Numbeer => Numbeer > 0;
			//predicate.Invoke(50);
			predicate(10);
			#endregion

			#region Func
			var Func = (int Name) => Name.ToString();
			Func.Invoke(10);
			Func(15);
			#endregion

			#region Action
			var action = (string Name) => Console.WriteLine($"Name is : {Name}");
			action("islam");
			#endregion
			#endregion
		}
	}
}
