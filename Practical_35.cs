using System;
class SK{
    int[] Arr_1d = new int[5];
    int[,] Arr_2d = new int[3,3];
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
        Console.WriteLine("Enter The Elements of 1D Arrays :-");
        for(int s=0;s<5;s++){
            Console.Write("Array_1d[{0}] = ",s);
            obj[s] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nPrinting of Arr_1d's Elements :- \n");
        for(int s=0;s<5;s++){
            Console.WriteLine("Arr_1d[{0}] = {1} " ,s,obj[s]);
        }
        Console.WriteLine("\nEnter The Elements of 2D Arrays :-\n");
        for(int s=0;s<3;s++){
            for(int k=0;k<3;k++){
                Console.Write("Arr_2d[{0}][{1}] = ",s,k);
                obj[s,k] = int.Parse(Console.ReadLine());   
            }
            Console.WriteLine(); 
        }
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
