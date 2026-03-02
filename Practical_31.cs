using System;
public class SK{
    public void fun(ref int a,ref int b){
        a += 10;
        b -= 10;
    }
}
public class Reference{
    public static void Main(){
        int s = 18, k = 19;
        Console.WriteLine("Before Calling SK Class :- ");
        Console.WriteLine("S = {0}   K = {1} ",s,k);
        SK obj = new SK();
        obj.fun(ref s,ref k);
        Console.WriteLine("\nAfter Calling SK Class :- ");
        Console.WriteLine("S = {0}   K = {1} ",s,k);        
        Console.ReadLine();
    }

}

