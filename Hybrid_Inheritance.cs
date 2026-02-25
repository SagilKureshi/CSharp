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
class C : A
{
    public C()
    {
        Console.WriteLine("SK in Child C : " + SK);
    }
}
class E : C
{
    public E()
    {
        Console.WriteLine("SK in Sub Child E : " + SK);
    }
}
class D : A
{
    public D()
    {
        Console.WriteLine("SK in Child D : " + SK);
    }
}
class SK
{
    public static void Main()
    {
        B b = new B();
        E e = new E();
        D d = new D();
        Console.ReadLine();
    }

}

