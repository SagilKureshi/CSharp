using System;
public class Parent{
    public int[][] SK  = new int[5][];
    public Parent(){
       SK[0] = new int[5];
       SK[1] = new int[1];
       SK[2] = new int[3];
       SK[3] = new int[1];
       SK[4] = new int[5];
    }
    
}
public class Child : Parent{   
    public void Show_Array()
    {
         for(int s = 0; s < SK.Length; s++)
        {
            for(int k = 0; k < SK[s].Length; k++)
            {
                Console.Write(SK[s][k] + " ");
            }
            Console.WriteLine();
        }   
    }
}
public class SK{
    public static void Main(){
        int count = 1;
        Child obj = new Child();
        for(int s = 0; s < obj.SK.Length; s++)
        {
            for(int k = 0; k < obj.SK[s].Length; k++)
            {
                obj.SK[s][k] = count++;
                if(count == 10) 
                    count = 0;
            }
        }    
        obj.Show_Array();
    }

}
