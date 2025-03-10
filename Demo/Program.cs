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
			string[] Names = { "Ali", "Omar", "Rana", "islam", "Zoz" };
			SotringTypesFuncDelegate<string, string> sortingType = SotringTypes.SortingStringAsc;
			SortingAlgorithms<string>.BubbleSort(Names, sortingType);
			foreach (string name in Names)
			{
				Console.WriteLine(name);
			}
			#endregion
			#endregion
		}
	}
}
