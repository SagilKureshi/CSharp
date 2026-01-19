using System;
class Array_2D{
	static void Main(){
		int[,] SK = new int[3,3];
		Console.WriteLine("Enter the elements(values) of Array :-");
		
		//loop for get the Elements(values) of the array from the User
		for(int s=0;s<SK.GetLength(0);s++){
			for(int k=0;k<SK.GetLength(1);k++){
				Console.Write("SK["+s+","+k+"] : ");
				SK[s,k] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine();
		}
		//loop for print the Elements(values) of the array  
		for(int s=0;s<SK.GetLength(0);s++){
			for(int k=0;k<SK.GetLength(1);k++){
			Console.Write("SK["+s+","+k+"] = "+SK[s,k]+"  ");
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	}
}