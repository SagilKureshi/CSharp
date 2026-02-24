using System;
class Parent{
    protected int sk = 10;
}
class Child1 : Parent{
    public Child1(){
        Console.WriteLine("SK in Child 1 : " + sk);
    }
}
class Sub_Child : Child1{
    public Sub_Child(){
        Console.WriteLine("SK in Sub Child : " + sk);
    }
}
class Child2 : Parent{
    public Child2(){
        Console.WriteLine("SK in Child 2 : " + sk);
    }
}
class SK{
    public static void Main(){
        Sub_Child sc = new Sub_Child();
        Child2 c2 = new Child2();
        Console.ReadLine();
    }
}