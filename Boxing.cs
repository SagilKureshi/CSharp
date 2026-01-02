using System;
class Boxing{
	static void Main(){
		int s = 99;
		object o = s;//Boxing (implicit)
		Console.WriteLine("Value of Int S = "+s);
		Console.WriteLine("Value of Object O = "+o);
		Console.ReadLine();
	}
}