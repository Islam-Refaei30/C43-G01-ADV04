namespace Demo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Test Demo Push");
			#region Part 01 Intro To Delegate &Example 01
			//int Result = StringFunctions.GetCountOfUpperChars();

			//Step 1 : Declare ref from delegate
			StringFuncDelegate Ref;

			//Step 2 : initialize ref from delegate [Point to Function]
			//Ref = new StringFuncDelegate(StringFunctions.GetCountOfUpperChars);
			Ref = StringFunctions.GetCountOfUpperChars; //sentex Suger
														//Ref += StringFunctions.GetCountOfLowerChars;
														//Step 3: Use Delegate Reference [Call Method]
			int Result = Ref.Invoke("IsLAm");
			Console.WriteLine(Result);
			#endregion
		}
	}
}
