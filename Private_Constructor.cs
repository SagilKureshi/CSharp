using System;
class Private_Constructor{
	static void Main(){
		Private_Constructor obj = new Private_Constructor();
		Console.ReadLine();
	}
	Private_Constructor(){ // The Default Access Specifire For Any Constructor IS Private
		Console.WriteLine("Hello SK from Private Constructor");		
	}
}
