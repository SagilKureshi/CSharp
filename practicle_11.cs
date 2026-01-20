using System;
class SK{
	static void Main(){
		Console.Write("Enter the size of array : ");
		int size = int.Parse(Console.ReadLine());
		int[] arr = new int[size];
		int sum=0;
		Console.WriteLine("Enter Elements of Array :- \n");
		for(int s=0;s<arr.Length;s++){
			Console.Write("a["+s+"] : ");
			arr[s] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine("\nPrint the Elements of Array :- \n");
		for(int s=0;s<arr.Length;s++){
			Console.Write("a["+s+"] = ");
			sum +=arr[s];
			Console.WriteLine(arr[s]);
		}
		Console.WriteLine("\nSum of Array's Elements  : "+sum);
		Console.ReadLine();
	}
}
