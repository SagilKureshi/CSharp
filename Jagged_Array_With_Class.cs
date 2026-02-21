using System;
class Parent{
    public int[][] SK  = new int[5][];
}
class Child : Parent{
    public void getsize()
    {
       SK[0] = new int[5];
       SK[1] = new int[1];
       SK[2] = new int[3];
       SK[3] = new int[1];
       SK[4] = new int[5];
    }

}
class SK{
    public static void Main(){
        Child obj = new Child();
        obj.getsize();
    }
}