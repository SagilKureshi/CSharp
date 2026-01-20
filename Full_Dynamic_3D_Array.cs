using System;
class Full_Dynamic_3D_Array{
	static void Main(){
		Console.Write("Enter The Number of Dimension/Table of 3D Array :- ");
		int t = int.Parse(Console.ReadLine());
		Console.Write("Enter The Number of Rows of 3D Array :- ");
		int r = int.Parse(Console.ReadLine());
		Console.Write("Enter The Number of Columns of 3D Array :- ");
		int c = int.Parse(Console.ReadLine());
		
		int[,,] SK = new int[t,r,c];
		
		Console.WriteLine("\nEnter The Elements(Values) of 3D Array :- \n");
		for(int s=0;s<t;s++){
			for(int k=0;k<r;k++){
				for(int z=0;z<c;z++){
					Console.Write("SK["+s+","+k+","+z+"] : ");
					SK[s,k,z] = int.Parse(Console.ReadLine());
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}		
		
		Console.WriteLine("Print The Elements(Values) of 3D Array :- \n");
		for(int s=0;s<t;s++){
			for(int k=0;k<r;k++){
				for(int z=0;z<c;z++){
				Console.Write("SK["+s+","+k+","+z+"] : "+SK[s,k,z]+"  ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}