using System;
class Inheritance{
    static void Main(){
        Child obj = new Child();
        obj.get();
        obj.show();
    }
}
class Parent{
    public int SK;
}
class Child: Parent{
    public void get(){
        SK = 18;
    }
    public void show(){
        Console.WriteLine("SK: " + SK);
    }
}