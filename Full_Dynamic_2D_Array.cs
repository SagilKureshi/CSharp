using System;
class Dynamic_2D_Array{
	static void Main(){
	/*	Console.Write("Enter the size of Rows of 2D Array :- ");
		int row = int.Parse(Console.ReadLine());
		Console.Write("Enter the size of Columns of 2D Array :- ");
		int col = int.Parse(Console.ReadLine());*/
		Console.Write("Enter the size of Rows and Columns of 2D Array Respectively :- ");
		int[,] SK = new int[int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())];
		Console.WriteLine("\nEnter the Elements(Values) of 2D Array :- \n");
		
		for(int s=0;s<SK.GetLength(0);s++){
			for(int k=0;k<SK.GetLength(1);k++){
				Console.Write("SK["+s+","+k+"] : ");
				SK[s,k] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine();
		}
		Console.WriteLine("\nPrint the Elements(Values) of 2D Array :- \n");		
		for(int s=0;s<SK.GetLength(0);s++){
			for(int k=0;k<SK.GetLength(1);k++){
				Console.Write("SK["+s+","+k+"] = "+SK[s,k]+"  ");
			}
			Console.WriteLine();
		}
	}
}