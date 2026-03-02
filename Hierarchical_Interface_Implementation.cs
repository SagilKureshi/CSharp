//Hierarchical Interface Inheritance
using System;
interface Interface{ 
    void Parent_fun();
}
class S : Interface{
    public void Parent_fun(){
        Console.WriteLine("Parent Interface Method Using Class A ");
    }
}
class K : Interface{
    public void Parent_fun(){
        Console.WriteLine("Parent Interface Method Using Class B ");
    }
}
class Hierarchical_Interface{
    public static void Main(){
        S S_obj = new S();
        S_obj.Parent_fun();
        K K_obj = new K();
        K_obj.Parent_fun();
        Console.ReadLine();
    }
}
