using  System;
class Jagged_3D_Arr{
	static void Main(){
		Console.Write("Enter The Dimensions Size of 3D Jagged Array : ");
		int d = int.Parse(Console.ReadLine());
		int[][][] SK = new int[d][][];
		Console.WriteLine("\nEnter The Row Size for each Dimensions : \n");  
		
		//Loop for getting size of rows Size for each Dimensions from the User
		for(int s=0;s<SK.Length;s++){
			Console.Write("SK[{0}] : ",s);
			SK[s] = new int[int.Parse(Console.ReadLine())][];
		}
		
		Console.WriteLine("\nEnter the Columns Size for each Rows");
		//Loop for getting size of Columns Size for each row from the User
		for(int s=0;s<SK.Length;s++){
			for(int k=0;k<SK[s].Length;k++){
				Console.Write("SK[{0}][{1}] : ",s,k);
				SK[s][k] = new int[int.Parse(Console.ReadLine())];
			}                             
			Console.WriteLine();
		}

		Console.WriteLine("\nGet all the Elements from the User");
		//Loop for get all Elements from the user
		for(int s=0;s<SK.Length;s++){
			for(int k=0;k<SK[s].Length;k++){
				for(int f=0;f<SK[s][k].Length;f++){
                Console.Write("SK[{0}][{1}][{2}] : ",s,k,f);
				SK[s][k][f] = int.Parse(Console.ReadLine());
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}	
		
		Console.WriteLine("\nPrint all the Elements");
		//Loop for print all the  Elements 
		for(int s=0;s<SK.Length;s++){
			for(int k=0;k<SK[s].Length;k++){
				for(int f=0;f<SK[k].Length;f++){
                Console.Write("SK[{0}][{1}][{2}] : {3}  ",s,k,f,SK[s][k][f]);
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}