using System;
class Parent{
    protected int s;
    public void show(){
        Console.WriteLine("Value of S : " + s);
    }
}
class Child : Parent{
    public Child(){
        s = 99;
    }
}
class SK{
    public static void Main(){
        Child child_obj = new Child();
        child_obj.show();
    }
}