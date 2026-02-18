using System;
class No_Name{
	static void get(SK obj){
		obj.s = 10;		
	}
	static void show(){
		Console.WriteLine("Value Of SK Class's Data Member S = ",obj.s);
	}
	static void Main(){
		SK obj = new SK();
		get(obj);
		show(obj);
		Console.Write(obj.s);
	}
}
class SK{
	public int s;
}	