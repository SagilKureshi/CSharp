using System;
        public delegate void Square_Cube(int s,int k);

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
        Square sq = new Square(obj.square);
        Cube c = new Cube(obj.cube);
        Console.Write("Enter Value of S :- ");
        int s1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Value of K :- ");
        int s2 = int.Parse(Console.ReadLine());
        s(s1,s2);
        sq(s1);
        c(s2);
        Console.ReadLine();
    }
}