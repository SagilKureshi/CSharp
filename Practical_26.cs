    using System;
    class Parent{
        protected int square(int s){
            return (s*s);
        }
    } 
    class Child : Parent{
        public int child(int s){
            return square(s);
        }
    }
    class Sub_Child : Child{
        public int sub_child(){
            Console.Write("Enter a Value to find it's Square : ");
            return child(int.Parse(Console.ReadLine()));
        }
    }
    class SK{
        public static void Main(){
            Sub_Child sb = new Sub_Child();
            Console.WriteLine("Square = " + (sb.sub_child()));
            Console.ReadLine();
        }

    }
