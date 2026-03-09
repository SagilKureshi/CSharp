using System;
class SK{

    int[] Arr_1d;
    int[,] Arr_2d;
    public int size,row,col;

    public void assign_size_1d(){
        Console.Write("Enter The Size of 1D Array :- ");
        size = int.Parse(Console.ReadLine());
        Arr_1d = new int[size];
    }
    public void assign_size_2d(){
        Console.Write("\nEnter The Row's Size of 2D Array :- ");
        row = int.Parse(Console.ReadLine());
        Console.Write("Enter The Column's Size of 2D Array :- ");
        col = int.Parse(Console.ReadLine());
        Arr_2d = new int[row,col];
    }
    public int this[int s]{
        get{
            if(s>=0 && s<size)
                return Arr_1d[s];
            return 0;
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
        obj.assign_size_1d();
        Console.WriteLine("\nEnter The Elements of 1D Arrays :-\n");
        for(int s=0;s<obj.size;s++){
            Console.Write("Array_1d[{0}] = ",s);
            obj[s] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nPrinting of Arr_1d's Elements :- \n");
        for(int s=0;s<obj.size;s++){
            Console.WriteLine("Arr_1d[{0}] = {1} " ,s,obj[s]);
        }
        obj.assign_size_2d();
        Console.WriteLine("\nEnter The Elements of 2D Arrays :-\n");
        for(int s=0;s<obj.row;s++){
            for(int k=0;k<obj.col;k++){
                Console.Write("Arr_2d[{0}][{1}] = ",s,k);
                obj[s,k] = int.Parse(Console.ReadLine());   
            }
            Console.WriteLine(); 
        }
        Console.WriteLine("Printing of Arr_2d's Elements :- \n");   
        for(int s=0;s<obj.row;s++){
            for(int k=0;k<obj.col;k++){
                Console.Write("Arr_2d[{0},{1}] = {2} ",s,k,obj[s,k]);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
