//Hybrid Interface Inheritance
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
interface Sub_Child : Child_1,Child_2{
    void sub_child_interface_fun();
}
class SK : Sub_Child{
    public void sub_child_interface_fun(){
        Console.WriteLine("Sub Child Interface Function");
    }
    public void child1_interface_fun(){
        Console.WriteLine("Child 1 Interface Function");
    }
    public void child2_interface_fun(){
        Console.WriteLine("Child 2 Interface Function");        
    }
    public void parent_interface_fun(){
        Console.WriteLine("Parent Interface Function");
    }
}
class Hybrid_Interface_Inheritance{
    public static void Main(){
        SK obj = new SK();
        obj.sub_child_interface_fun();
        obj.child1_interface_fun();
        obj.child2_interface_fun();
        obj.parent_interface_fun();
        Console.ReadLine();
    }
}