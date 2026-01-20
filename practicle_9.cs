using System;
class  Unboxing{
	static void Main(){
		int n = 99 ;
		Object obj = n;//Boxing
		int s = (int)obj;//Unboxing 
		Console.WriteLine("Value of Integer n = "+n);
		Console.WriteLine("Value of object obj = "+obj);
		Console.WriteLine("Value of integer S = "+s);
		Console.ReadLine();
	}
}