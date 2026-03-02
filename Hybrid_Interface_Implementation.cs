//Hybrid Interface Inheritance
using System;
interface Interface_1{ 
    void Parent_fun_1();
}
interface Interface_2{ 
    void Parent_fun_2();
}
class Parent: Interface_1,Interface_2{
    public void fun(){
        Console.WriteLine("Parent Class :- ");
    }
    public void Parent_fun_1(){
        Console.WriteLine("Interface 1's Method");
    }
    public void Parent_fun_2(){
        Console.WriteLine("Interface 2's Method ");
    }
}
class Child : Parent{
    public Child(){
        Console.WriteLine("Child Class :- ");
    }
}
class Hybrid_Interface{
    public static void Main(){
        Child obj = new Child();
        obj.fun();
        obj.Parent_fun_1();
        obj.Parent_fun_2();
        Console.ReadLine();
    }
}
