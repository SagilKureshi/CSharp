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
            if(s>=0 && s<Arr_1d_size)
                return Arr_1d[s];
            return 0;
        }
        set{
            if(s>=0 && s<Arr_1d_size)
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
        Console.WriteLine("Printing of Arr_1d's Elements :- \n");

        for(int s=0;s<obj.Arr_1d_size;s++){
            Console.WriteLine("Arr_1d[{0}] = {1} " ,s,obj[s]);
        }
        obj[0,0] = 1;
        obj[0,1] = 2;   
        obj[0,2] = 3;
        obj[1,0] = 4;
        obj[1,1] = 5;
        obj[1,2] = 6;
        obj[2,0] = 7;
        obj[2,1] = 8;
        obj[2,2] = 9;
        Console.WriteLine("\nPrinting of Arr_2d's Elements :- \n");   
        for(int s=0;s<3;s++){
            for(int k=0;k<3;k++){
                Console.Write("Arr_2d[{0},{1}] = {2} ",s,k,obj[s,k]);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
