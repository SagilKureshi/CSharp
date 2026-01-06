using System;
class  Unboxing{
	static void Main(){
		Object obj = 99;
		int s = (int)obj;
		Console.WriteLine("Value of object obj = "+obj);
		Console.WriteLine("Value of integer S = "+s);
		Console.ReadLine();
	}
}