using System;
class No_Name{
	public static void Main(){
		SK a = new SK();
		Console.Write("Enter Value of S : ");
		a.s = int.Parse(Console.ReadLine());
		Console.WriteLine("Value of S = " + a.s);
	}
}
class SK{
	public int s;
}	
