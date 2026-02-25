//Hierarchical Inheritance
using System;
class A{
    protected int sk = 10;
    public A(){
        Console.WriteLine("SK in Parent A : " + sk);
    }
}
class B : A{
    public B(){
        Console.WriteLine("SK in Child B  : " + sk);
    }
}
class C : A{
    public C(){
        Console.WriteLine("SK in Child C : " + sk);
    }
}
class SK{
    public static void Main(){
        B b = new B();
        C c = new C();
        Console.ReadLine();
    }
}