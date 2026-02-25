//Hybrid Inheritance
using System;
class A
{
    protected int SK = 10;
    public A()
    {
        Console.WriteLine("SK in Parent A : " + SK);
    }
}
class B : A
{
    public B()
    {
        Console.WriteLine("SK in Child B : " + SK);
    }
}
class D : B
{
    public D()
    {
        Console.WriteLine("SK in Sub Child D : " + SK);
    }
}
class C : A
{
    public C()
    {
        Console.WriteLine("SK in Child C : " + SK);
    }
}
class SK
{
    public static void Main()
    {
        D d = new D();
        C c = new C();
        Console.ReadLine();
    }
}