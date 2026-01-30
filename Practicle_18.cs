using System;
class Menu{
	static void Main(){
		char yn;	
		do{
			Console.WriteLine("MenuMenu for Watchs :-\n");
			Console.WriteLine("Press [1] for Rolex Watch");
			Console.WriteLine("Press [2] for Patek Philippe Watch");
			Console.WriteLine("Press [3] for Omega Watch");
			Console.WriteLine("Press [4] for Titan Watch");
			Console.WriteLine("Press [5] for Casio Watch\n");
			
			Console.Write("Your Choice : ");
			int choice = int.Parse(Console.ReadLine());
			
			switch(choice){
				case 1:
					Console.WriteLine("Welcome to Rolex Watchs :-");
					Console.WriteLine("Quantity\t\t\tModel\t\\t\tPrice");
			}
			Console.Write("Do you want to Continue Press [y/n] : ");
			yn = char.Parse(Console.ReadLine());
		}while(yn == 'y');
	}
}