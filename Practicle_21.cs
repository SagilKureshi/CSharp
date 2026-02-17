using System;
class Copy_Constructor{
	static void Main(){
		SK obj1 = new SK(18);
		SK obj2 = new SK(19);
		SK obj3 = new SK(obj1,obj2);
		obj3.show(obj1,obj2);
		Console.ReadLine();
	}
}
class SK{ // The Default Access Specifier For Any Class Is Internal Which Can Be Use From Same File
	int sk;
	public SK(int s){
		sk = s;
		Console.WriteLine("Parameterized Constructor");
	}
	public 	SK(SK s,SK k){ // Copy Constructor
		Console.WriteLine("\nCopy Constructor\n");
		sk = s.sk+k.sk;
	}
	public void show(SK n1,SK n2){
		Console.WriteLine("Value of obj1.sk = "+n1.sk);
		Console.WriteLine("Value of obj2.sk = "+n2.sk);
		Console.WriteLine("\nsum of obj1.sk + obj2.sk = "+sk);
	}
}