using System;
class FSK_Fast_Food{
	static int Pizza = 499;
	static int Burger = 299;
	static int Panipuri = 199;
	static int Sevpuri = 209;
	static int Samosa = 149;
	static int Pizza_quantity;
	static int Burger_quantity;
	static int Panipuri_quantity;
	static int Sevpuri_quantity;
	static int Samosa_quantity;
	
	static void Food_Function(string name,int price){
		Console.WriteLine("|----------------------------|");
		Console.WriteLine("|Description\t|\tPrice|");
		Console.WriteLine("|{0}\t\t|\t {1} |",name,price);
		Console.WriteLine("|----------------------------|");
		Console.Write("\nDo you Want To Buy [y/n] : ");
		char ny = char.Parse(Console.ReadLine());
		
		if(ny == 'y' || ny == 'Y'){
			Bill(name,price);
		}
	}
	
	static void Bill(string name,int price){
		
		if(price == 499){
			Console.Write("Enter Quantity Of Your Order : ");
			int Pizza_quantity = int.Parse(Console.ReadLine());
			int total_pizza_price = (Pizza_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Pizza_quantity,price,total_pizza_price);
		}
		else if(price == 299){
			Console.Write("Enter Quantity Of Your Order : ");
			int Burger_quantity = int.Parse(Console.ReadLine());
			int total_barger_price = (Burger_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Burger_quantity,price,total_barger_price);
		}
		else if(price == 199){
			Console.Write("Enter Quantity Of Your Order : ");
			int Panipuri_quantity = int.Parse(Console.ReadLine());
			int total_panipuri_price = (Panipuri_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Panipuri_quantity,price,total_panipuri_price);
		}
		else if(price == 209){
			Console.Write("Enter Quantity Of Your Order : ");
			int Sevpuri_quantity = int.Parse(Console.ReadLine());
			int total_sevpuri_price = (Sevpuri_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Sevpuri_quantity,price,total_sevpuri_price);
		}
		else{
			Console.Write("Enter Quantity Of Your Order : ");
			int Samosa_quantity = int.Parse(Console.ReadLine());
			int total_samosa_price = (Samosa_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Samosa_quantity,price,total_samosa_price);
		}
		
		Console.WriteLine();
		
	}
	static void Main(){
		char yn;
		do{
			Console.WriteLine("\t*****Welcome to FSK 7 Stars Fast Food*****\t");
			Console.WriteLine("\t*****FSK Fast Food Menu*****\t\n");
			Console.WriteLine("[1] Enter for Pizza");
			Console.WriteLine("[2] Enter for Burger");
			Console.WriteLine("[3] Enter for Panipuri");
			Console.WriteLine("[4] Enter for Sevpuri");
			Console.WriteLine("[5] Enter for Samosa");
			Console.WriteLine("[0] Enter for  Exit\n");
			
			Console.Write("Enter Your Choice : ");
			int choice = int.Parse(Console.ReadLine());
			
			switch(choice){
				case 1:
					Console.WriteLine("\nWelcome FSK 7 Stars Pizza\n");
					Food_Function("Pizza",Pizza);
					break;
				
				case 2:
					Console.WriteLine("\nWelcome FSK 7 Stars Burger\n");
					Food_Function("Burger",Burger);
					break;
					
				case 3:
					Console.WriteLine("\nWelcome FSK 7 Stars Panipuri\n");
					Food_Function("Panipuri",Panipuri);
					break;
					
				case 4:
					Console.WriteLine("\nWelcome FSK 7 Stars Sevpuri\n");
					Food_Function("Sevpori",Sevpuri);
					break;
					
				case 5:
					Console.WriteLine("\nWelcome FSK 7 Stars Samosa\n");
					Food_Function("Samosa",Samosa);
					break;
					
				case 0:
					Console.WriteLine("\nThanks For Visit");
					break;
					
				default:
					Console.WriteLine("Kindly Chose As Above Menu");
					break;
								
			} 
			Console.Write("\nDo You Want To Continue [y/n] : ");
			yn = char.Parse(Console.ReadLine());
			Console.Clear();
		}while(yn == 'y' || yn == 'Y');
		Console.ReadLine();
	}
}