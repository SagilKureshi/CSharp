using System;
class Menu{
	static void Main(){
		char yn;	
		do{
			Console.WriteLine("Menu for Watches :-\n");
			Console.WriteLine("Press [1] for Rolex Watches");
			Console.WriteLine("Press [2] for Patek Philippe Watches");
			Console.WriteLine("Press [3] for Omega Watches");
			Console.WriteLine("Press [4] for Titan Watches");
			Console.WriteLine("Press [5] for Casio Watches\n");
			
			Console.Write("Your Choice : ");
			int choice = int.Parse(Console.ReadLine());
			
			switch(choice){
				case 1:
					Console.WriteLine("Welcome to Rolex Watches :-");
					Console.WriteLine("Quantity\t\t\tModel\t\\t\tPrice");
					break;
				case 2:
					Console.WriteLine("Welcome to Patek Philippe Watches :-");
					Console.WriteLine("Quantity\t\t\tModel\t\\t\tPrice");
					break;
				case 3:
					Console.WriteLine("Welcome to Omega Watches :-");
					Console.WriteLine("Quantity\t\t\tModel\t\\t\tPrice");
					break;
				case 4:
					Console.WriteLine("Welcome to Titan Watches :-");
					Console.WriteLine("Quantity\t\t\tModel\t\\t\tPrice");
					break;	
				case 5:
					Console.WriteLine("Welcome to Casio Watches :-");
					Console.WriteLine("Quantity\t\t\tModel\t\\t\tPrice");
					break;
			}
			Console.Write("Do you want to Continue Press [y/n] : ");
			yn = char.Parse(Console.ReadLine());
		}while(yn == 'y');
	}
}
