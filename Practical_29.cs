using System;
class Method_OverLoading{
    public void fun(){
        Console.WriteLine("Method with no parameter");
    }
    public void fun(int a){
        Console.WriteLine("Method with one Integer parameter a = " + a);
    }
    public void fun(double d){
        Console.WriteLine("Method with one Double parameter d = " + d);
    }
    public void fun(string s){
        Console.WriteLine("Method with one String parameters s = " + s);
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
