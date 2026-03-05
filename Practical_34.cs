using System;
class SK{
    int[] arr = new int[3]; 
    public int this[int s]{
        set{
            if(s >= 0 && s < arr.Length)
                if(value > 0)
                    arr[s] = value;
        }
        get{
            if(s >= 0 && s < arr.Length)
                return arr[s];
            return 0;       
        }
    } 
}
class Indexer{
    public static void Main(){
        SK obj = new SK();
        obj[0] = 10;
        obj[1] = 20;
        obj[2] = -18;
        Console.WriteLine("SK[0] = " + obj[0]);
        Console.WriteLine("SK[0] = " + obj[1]);
        Console.WriteLine("SK[0] = " + obj[2]);
        Console.ReadLine();
    }
}