using System;
class Grand_Parent{
    protected int s;
    public void show_grand_parent(){
        Console.WriteLine("Value of S in Grand Parent Class: " + s);
    }
}
class Parent : Grand_Parent{
    public void show_parent(){
        Console.WriteLine("Value of S in Parent Class: " + s);
    }
}
class Child : Parent{
    public Child(){
        s = 99;
    }
    public void show_child(){
        Console.WriteLine("Value of S in Child Class: " + s);
    }
}
class SK{
    public static void Main(){
        Child child_obj = new Child();
        child_obj.show_grand_parent();
        child_obj.show_parent();
        child_obj.show_child();

    }
}