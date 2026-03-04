//Hierarchical Interface Inheritance
using System;
interface Parent{
    void parent_interface_fun();
}
interface Child_1 : Parent{
    void child1_interface_fun();
}
interface Child_2 : Parent{
    void child2_interface_fun();
}
class class_1 : Child_1{
    public void parent_interface_fun(){
        Console.WriteLine("Parent Interface Function");
    }
    public void child1_interface_fun(){
        Console.WriteLine("Child 1 Interface Function");
    }
}
class class_2 : Child_2{
    public void parent_interface_fun(){
        Console.WriteLine("Parent Interface Function");
    }
    public void child2_interface_fun(){
        Console.WriteLine("Child 2 Interface Function");
    }
}
class Hierarchical_Interface_Inheritance{
    public static void Main(){
        class_1 obj1 = new class_1();
        class_2 obj2 = new class_2();
        Console.WriteLine("Class 1 :- ");
        obj1.parent_interface_fun();
        obj1.child1_interface_fun();
        Console.WriteLine("\nClass 2 :- ");
        obj2.parent_interface_fun();
        obj2.child2_interface_fun();
        Console.ReadLine();
    }
}
