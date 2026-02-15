using System;
class Copy_Constructor{
	static void Main(){
		SK obj1 = new SK(18);
		SK obj2 = new SK(obj1);
		Console.ReadLine();
	}
}
class SK{ // The Default Access Specifier For Any Class Is Internal Which Can Be Use From Same File
	public SK(int s){
		Console.WriteLine("Value of Integer Type S From Obj1 = "+s);
	}
	public 	SK(SK k){ // Copy Constructor
		Console.WriteLine("Value of SK Type K From Obj2 = "+k);
	}
}