using System;
class Jagged_Array{
	static void Main(){
		int[][] SK = new int[3][];//Jagged Array
		SK[0] = new int[3];
		SK[1] = new int[2];
		SK[2] = new int[4];
		
		SK[0][0] = 8;
		SK[1][1] = 5;
		SK[2][2] = 3;
		
		Console.WriteLine("Total Rows Size = "+SK.Length);
		Console.WriteLine("\n0th Row's Columns Size = "+SK[0].Length);
		Console.WriteLine("1st Row's Columns Size = "+SK[1].Length);
		Console.WriteLine("2nd Row's Columns Size = "+SK[2].Length+"\n");
		
		//foreach loops for printing Elements of Jagged Array
		foreach(int[] s in SK){
			foreach(int k in s){
				Console.Write(k+ " ");
			} 
			Console.WriteLine();
		}
	}
}