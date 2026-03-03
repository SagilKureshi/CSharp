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
        public void assign(){
            Console.WriteLine("Enter Your Name : ");
            name = Console.ReadLine();
        }
    }
    public string Property_3 // Write Only Property
    {
        set{
            name = value;
        }
        public void show(){
            Console.WriteLine("Your Name Is : " + name);
        }
    }
}
class Properties{
    public static void Main(){
        SK obj = new SK();
        Console.Write("Enter Your name :- ");
        obj.Property_1 = Console.ReadLine();
        Console.Write("Your name is :- ");
        Console.WriteLine(obj.Property_1);
        obj2.assign();
        obj2.Property_2;
        Console.WriteLine("Enter Your Name : ");
        obj.Property_3 = Console.ReadLine();
        obj.show();
        Console.ReadLine();
    }
}
