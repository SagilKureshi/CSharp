using System;
class Do_while_Arr{
	static void Main(){
		Console.Write("Enter The size of Array : ");
		int size = int.Parse(Console.ReadLine());
		int[] SK = new int[size];
		Console.WriteLine("\nEnter The Elements(Values) of Array :-\n");
		int s = 0;
		
		//Loop for get the Elements of Array from the User
		do{
			Console.Write("SK[{0}] : ",s);
			SK[s] = int.Parse(Console.ReadLine());
			s++;
		}while(s<SK.Length);
		
		s=0;
		Console.WriteLine();
		Console.WriteLine("\nPrint The Elements(Values) of Array :-\n");
		//Loop for print the Elements of Array
		do{
			Console.WriteLine("SK[{0}] = {1}",s,SK[s]);
			s++;
		}while(s<SK.Length);
	}
}