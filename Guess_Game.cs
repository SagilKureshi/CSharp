using System;
class Guess{
    static void Main(String[] args){
        Console.WriteLine("Guess Number Between 1 - 100 : ");
		Console.WriteLine("Enter -1 to Exit the Game");
		Random r = new Random();
		int rn = r.Next(1,101);
		int count = 0;
		while(true){
			
			Console.Write("Enter Number : ");
			int un = int.Parse(Console.ReadLine());

			if(un == -1){
				Console.WriteLine("Exit From The Game");
				break;
			}
			else if(un > rn){
				count++;
				Console.WriteLine("Guess Small Number");
			}
			else if(un < rn){
				count++;
				Console.WriteLine("Guess Big Number");
			}
			else{
				count++;
				Console.WriteLine("Congtratulations!.....\nYou Guess Right Number");
				Console.WriteLine("Number of Guesses : "+count);
				break;
			}
		}
		Console.ReadLine();
    }
}