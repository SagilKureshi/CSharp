using System;
class User_Array{
	static void Main(){
		Console.Write("Enter size of Array : ");
		int size = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the Elements(Values) of Array :- \n");
		int[] arr = new int[size];
		for(int s=0;s<arr.Length;s++){
			Console.Write("arr["+s +"] : ");
			arr[s] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Print the Elements(Values) of Array :- \n");		
		for(int s=0;s<arr.Length;s++){
			Console.WriteLine("arr["+s +"] = "+arr[s]);
		}
	}
}
