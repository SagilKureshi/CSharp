using System;
class SK{
    string name;
    public string Property_1{// Read - Write Both Property
        get{
            return name;
        }
        set{
            name = value;
        }
    }
    public string Property_2 // Read Only Property
    {
        get{
            return name;
        }
    }
    public string Property_3 // Write Only Property
    {
        set{
            name = value;
        }
    }
    public void assign(){
        Console.Write("Enter Your Name : ");
        name = Console.ReadLine();
    }
    public void show(){
        Console.WriteLine("Your Name Is : " + name);
    }
}
class Properties{
    public static void Main(){
        SK obj = new SK();
        Console.WriteLine("Read & Write Both Properties :- ");
        Console.Write("Enter Your name :- ");
        obj.Property_1 = Console.ReadLine();
        Console.WriteLine("Your name is :- " + obj.Property_1);
        Console.WriteLine("\nRead Only Property :- ");
        obj.assign();
        Console.WriteLine("Your Name Is : " + obj.Property_2);
        Console.WriteLine("\nWrite Only Property :- ");
        Console.Write("Enter Your Name : ");
        obj.Property_3 = Console.ReadLine();
        obj.show();
        Console.ReadLine();
    }
}
