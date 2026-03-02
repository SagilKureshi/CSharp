using System;
class SK{
    public void fun(out int a,out int b){
        Console.Write("Enter Number 1 : ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter Number 2 : ");
        b = int.Parse(Console.ReadLine());
        a *= a;
        b = (b*b*b);
    }

}
class Out_Keyword{
    public static void Main(){
        int s,k;
        SK obj = new SK();
        obj.fun(out s,out k);
        Console.WriteLine("Square of Number 1 = " +  s);
        Console.WriteLine("Cube of Number 2 = " + k);
        Console.ReadLine();
    }
}