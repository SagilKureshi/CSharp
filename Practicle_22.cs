using System;
class Mix_Constructor{
	static void Main(){
		SK obj1 = new SK();
		SK obj2 = new SK(99,199);
		Console.ReadLine();
	}
}
class SK{
	public SK(){// Default Constructor
		Console.WriteLine("Default Constructor");
	}
	public SK(int s,int k){// Parameterized Constructor
		Console.WriteLine("Parameterized Constructor");
	}
	static SK(){// Static Constructor
		Console.WriteLine("Static Constructor");
	}
}