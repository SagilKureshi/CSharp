using System;
class SK{
    int[] Arr_1d = new int[5];
    int[,] Arr_2d = new int[3,3];
    public int Arr_1d_size;
    public SK(){
        Arr_1d_size = Arr_1d.Length;
        //public int Arr_2d_size = Arr_2d.Length;
    }
    public int this[int s]{
        get{
            return Arr_1d[s];
        }
        set{
            Arr_1d[s] = value;
        }
    }
    public int this[int s,int k]{
        get{
            return Arr_2d[s,k];
        }
        set{
            Arr_2d[s,k] = value;
        }
    }
}
class Indexer_Overloading{
    public static void Main(){
        SK obj = new SK();
        obj[0] = 10;
        obj[1] = 20;
        obj[2] = 30;
        obj[3] = 40;
        obj[4] = 50;
        Console.WriteLine("Printing of Arr_1d's Elements :- ");

        for(int s=0;s<obj.Arr_1d_size;s++){
            Console.WriteLine("Arr_1d[{0}] = {1} " ,s,obj[s]);
        }
        Console.ReadLine();
    }
}