using System;
class Parameterized_Constructor{
	static void Main(){
		SK obj = new SK(18,1);
		Console.ReadLine();
	}
}
public class SK{
	public SK(int s,int k){ //Parameterized Constructor
		Console.WriteLine("Value of S = "+s);
		Console.WriteLine("Value of K = "+k);
	}
}