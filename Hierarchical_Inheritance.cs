using System;
class Parent{
    protected int sk = 10;
}
class Child1 : Parent{
    public Child1(){
        Console.WriteLine("SK in Child 1 : " + sk);
    }
}
class Child2 : Parent{
    public Child2(){
        Console.WriteLine("SK in Child 2 : " + sk);
    }
}
class SK{
    public static void Main(){
        Child1 c1 = new Child1();
        Child2 c2 = new Child2();
        Console.ReadLine();
    }
}