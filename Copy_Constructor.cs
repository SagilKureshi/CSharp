using System;
class Copy_Constructor{
	static void Main(){
		SK obj1 = new SK(18);
		obj1.show();
		SK obj2 = new SK(obj1);
		obj2.show();
		Console.ReadLine();
	}
}
class SK{ // The Default Access Specifier For Any Class Is Internal Which Can Be Use From Same File
	int s1;
	public SK(int s){
		s1 = s;
		Console.WriteLine("Parameterized Constructor ");
	}
	public 	SK(SK k){ // Copy Constructor
		s1 = k.s1;
		Console.WriteLine("\nCopy Constructor ");
	}
	public void show(){
		Console.WriteLine("Value of s1 = "+s1);
	}
}
