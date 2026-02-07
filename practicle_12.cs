using System;
class Array_2D{
	static void Main(){
		int[,] SK = new int[2,2];		
		SK[0,0] = 1;
		SK[0,1] = 2;
		SK[1,0] = 3;
		SK[1,1] = 4;
	
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
