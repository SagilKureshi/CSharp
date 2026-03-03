using System;
class SK{
    string name;
    public string property_name_1{
        get{
            return name;
        }
        set{
            name = value;
        }
    }
public string property_name_2
    {
        
    }
}
class Properties{
    public static void Main(){
        SK obj = new SK();
        Console.Write("Enter Your name :- ");
        obj.property_name = Console.ReadLine();
        Console.Write("Your name is :- ");
        Console.WriteLine(obj.property_name);
        Console.ReadLine();
    }
}