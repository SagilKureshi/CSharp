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
					Console.WriteLine("Quantity\t\tModel\t\t\t\t\tPrice(INR)");
					Console.WriteLine("1\t\tRolex Daytona Paul Newman 6239\t\t\t32,411,568($17.75 million)");
					break;
				case 2:
					Console.WriteLine("Welcome to Patek Philippe Watches :-");
					Console.WriteLine("Quantity\t\tModel\t\t\t\t\tPrice(INR)");
					Console.WriteLine("1\t\tPatek Philippe Grandmaster Chime Ref. 6300A-010\t\t\t\t\t₹272 crore ($31.1 million)");
					break;
				case 3:
					Console.WriteLine("Welcome to Omega Watches :-");
					Console.WriteLine("Quantity\t\tModel\t\t\t\t\tPrice(INR)");
					Console.WriteLine("1\t\tOmega vintage Speedmaster Ref. 2915-1\t\t\t\t\t₹27,76,64,000($17.75 million)");
					break;
				case 4:
					Console.WriteLine("Welcome to Titan Watches :-");
					Console.WriteLine("Quantity\t\tModel\t\t\t\t\tPrice(INR)");
					Console.WriteLine("1\t\t Titan Nebula Jalsa\t\t\t\t\t₹40.5 lakh (4.05 million INR)");
					break;	
				case 5:
					Console.WriteLine("Welcome to Casio Watches :-");
					Console.WriteLine("Quantity\t\tModel\t\t\t\t\tPrice(INR)");
					Console.WriteLine("1\t\tModel\t\t\t\t\tPrice(INR)");
					break;
			}
			Console.Write("Do you want to Continue Press [y/n] : ");
			yn = char.Parse(Console.ReadLine());
		}while(yn == 'y');
	}
}
