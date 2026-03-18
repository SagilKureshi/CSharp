using System;
        public delegate void Square_Cube(int s);

class SK
{
    public void square(int s)
    {
        Console.WriteLine("The Square of {0} is :- {1}",s,s*s);
    }
    public void cube(int s)
    {
        Console.WriteLine("The Cube of {0} is :- {1}",s,s*s*s);
    }
}
class Delegate
{
    public static void Main()
    {
        SK obj = new SK();
        Square_Cube sq = new Square_Cube(obj.square);
        Console.Write("Enter Value a Value :- ");
        int s1 = int.Parse(Console.ReadLine());
        sq+=obj.cube;
        sq(s1);
        Console.ReadLine();
    }
}