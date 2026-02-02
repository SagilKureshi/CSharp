using System;
class Menu{
	static int rolex_quant = 0;
	static int rolex = 32411568;
	static int patek = 272;
	static int patek_quant = 0; 
	static int Omega = 277664000;
	static int omega_quant = 0;
	static int Titan = 4000000;
	static int titan_quant = 0;
	static int casio = 49995;
	static int casio_quant = 0;
		
	static void Rolex(){
		Console.WriteLine("Welcome to Rolex Watches :-");
		Console.WriteLine("Quantity\t\tModel\t\t\t\t\tPrice(INR)");
		Console.WriteLine("{0}\t\tRolex Daytona Paul Newman 6239\t\t\t32,411,568($17.75 million)",rolex_quant);	
	}		
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
					Rolex();
					break;
				case 2:

						
					break;
				case 3:
						
					Console.WriteLine("Welcome to Omega Watches :-");
						Console.WriteLine("Quantity\t\tModel\t\t\t\t\tPrice(INR)");
						Console.WriteLine("{0}\t\tOmega vintage Speedmaster Ref. 2915-1\t\t\t\t\t₹27,76,64,000($17.75 million)",omega_quant);
					break;
				case 4:
						Console.WriteLine("Welcome to Titan Watches :-");
					Console.WriteLine("Quantity\t\tModel\t\t\t\t\tPrice(INR)");
					Console.WriteLine("{0}\t\t Titan Nebula Jalsa\t\t\t\t\t₹4000000 (4.05 million INR)",titan_quant);
						break;	
				case 5:
					Console.WriteLine("Welcome to Casio Watches :-");
					Console.WriteLine("Quantity\t\tModel\t\t\t\t\tPrice(INR)");
					Console.WriteLine("{0}\t\tCASIO G-SHOCK Men Watch\t\t\t\t\t₹49995",casio_quant);
					break;
			}
			Console.Write("Do you want to Continue Press [y/n] : ");
			yn = char.Parse(Console.ReadLine());
		}while(yn == 'y');
		}
}
