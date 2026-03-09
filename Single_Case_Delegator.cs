using System;
     public delegate void Sum(int s,int k);
class SK
{
    public void sum(int s,int k)
    {
        Console.WriteLine("The Sum of {0} and {1} is :- {2}",s,k,s+k);
    }
}
class Delegate
{
    public static void Main()
    {
        SK obj = new SK();
        Sum s = new Sum(obj.sum);
        Console.Write("Enter Value of S :- ");
        int s1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Value of K :- ");  
        int s2 = int.Parse(Console.ReadLine());
        s(s1,s2);
        Console.ReadLine();
    }
}