using System;
class Jagged_2D_Array{
	static void Main(){
		int [][] SK = new int[4][];
		SK[0] = new int[2];
		SK[1] = new int[3];
		SK[2] = new int[4];
		
		SK[0][0] = 1;
		SK[0][1] = 2;
		SK[1][0] = 3;
		SK[1][1] = 4;
		SK[1][2] = 5;
		SK[2][0] = 6;
		SK[2][1] = 7;
		SK[2][2] = 8;
		SK[2][3] = 9;
		
		foreach(int[] s in SK){
			foreach(int k in s)
				Console.WriteLine(k+" ");
		}Console.WriteLine();
	}
}