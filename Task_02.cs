using System;
class Parent{
    protected void disp(){
        Console.WriteLine("Hello From Disp");
    }
}
class Child : Parent{
    public void child(){
        Console.WriteLine("This is Child Class");
        disp();
    }
}
class Sub_Child : Child{
    public void sub_child(){
        Console.WriteLine("This is Sub Child Class");
        disp();
    }
}
class SK{
    public static void Main(){
        Sub_Child Sub_child_obj = new Sub_Child();
        Sub_child_obj.child();
        Sub_child_obj.sub_child();

    }
}
