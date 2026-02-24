using System;
class Method_OverLoading{
    public void fun(){
        Console.WriteLine("Method with no parameter");
    }
    public void fun(int a){
        Console.WriteLine("Method with one Integer parameter a = " + a);
    }
    public void fun(double d){
        Console.WriteLine("Method with one Double parameter a = " + d);
    }
    public void fun(int a, int b){
        Console.WriteLine("Method with two Integer parameters a = " + a + " and b = " + b);
    }
}
class SK{
    public static void Main(){
        Method_OverLoading obj = new Method_OverLoading();
        obj.fun();
        obj.fun(10);
        obj.fun(10.5);
        obj.fun(10, 20);
        Console.ReadLine();
    }
}