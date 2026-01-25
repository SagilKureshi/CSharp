using System;
class Full_Dynamic_Jagged_Array{
	static void Main(){
		Console.Write("Enter the size of 2D Jagged Array's Rows: ");
		int r = int.Parse(Console.ReadLine());
		int[][] SK = new int[r][];
		Console.WriteLine("\nEnter the size of Columns for each Rows :- \n");
		//Loop for get all Row's Columns size from the User
		for(int s=0;s<SK.Length;s++){
			Console.Write("SK["+s+"] row = ");
			SK[s] = new int[int.Parse(Console.ReadLine())];
		}
		Console.WriteLine();	
		//Loop for get all Elements from the User
		for(int s=0;s<SK.Length;s++){
			for(int k=0;k<SK[s].Length;k++){
				Console.Write("SK ["+s+"]["+k+"] : ");
				SK[s][k] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine();
		}
		
		//Loop for Print all Elements
		for(int s=0;s<SK.Length;s++){
			for(int k=0;k<SK[s].Length;k++){
				Console.Write("SK ["+s+"]["+k+"] = "+SK[s][k]+"  ");
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	}
}
