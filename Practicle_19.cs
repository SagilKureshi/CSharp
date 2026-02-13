using System;
class SK_Fast_Food{
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
	static int total_pizza_price;
	static int total_burger_price;
	static int total_panipuri_price;
	static int total_sevpuri_price;
	static int total_samosa_price;
	static float TOTAL;
	static bool Pay_Bill = false;
	
	static void Food_Function(string name,int price){
		Console.WriteLine("|-------------------------|");
		Console.WriteLine("|  Description  |  Price  |");
		Console.WriteLine("|-------------------------|");
		Console.WriteLine("|  {0}\t|  {1}|",name,price+"    ");
		Console.WriteLine("|-------------------------|");
		Console.Write("\nDo you Want To Buy [y/n] : ");
		char ny = char.Parse(Console.ReadLine());
		
		if(ny == 'y' || ny == 'Y'){
			Bill(name,price);
			}
	}
	
	static void Bill(string name,int price){
		
		if(price == 499){
			Console.Write("\nEnter Quantity Of Your Order : ");
			Pizza_quantity = int.Parse(Console.ReadLine());
			total_pizza_price = (Pizza_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Pizza_quantity,price,total_pizza_price);
		}
		else if(price == 299){
			Console.Write("\nEnter Quantity Of Your Order : ");
			Burger_quantity = int.Parse(Console.ReadLine());
			total_burger_price = (Burger_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Burger_quantity,price,total_burger_price);
		}
		else if(price == 199){
			Console.Write("\nEnter Quantity Of Your Order : ");
			Panipuri_quantity = int.Parse(Console.ReadLine());
			total_panipuri_price = (Panipuri_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Panipuri_quantity,price,total_panipuri_price);
		}
		else if(price == 209){
			Console.Write("\nEnter Quantity Of Your Order : ");
			Sevpuri_quantity = int.Parse(Console.ReadLine());
			total_sevpuri_price = (Sevpuri_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Sevpuri_quantity,price,total_sevpuri_price);
		}
		else{
			Console.Write("\nEnter Quantity Of Your Order : ");
			Samosa_quantity = int.Parse(Console.ReadLine());
			total_samosa_price = (Samosa_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Samosa_quantity,price,total_samosa_price);
		}
		

	}
	static void Main(){
		char yn;
		do{
			Console.WriteLine("|------------------------------------------|");
			Console.WriteLine("|*****Welcome to SK 7 Stars Fast Food*****|");
			Console.WriteLine("|------------------------------------------|");
			Console.WriteLine("|\t*****SK Fast Food Menu*****\t   |");
			Console.WriteLine("|------------------------------------------|");
			Console.WriteLine("|\t[1] Enter for Pizza\t\t   |");
			Console.WriteLine("|\t[2] Enter for Burger\t\t   |");
			Console.WriteLine("|\t[3] Enter for Panipuri\t\t   |");
			Console.WriteLine("|\t[4] Enter for Sevpuri\t\t   |");
			Console.WriteLine("|\t[5] Enter for Samosa\t\t   |");
			Console.WriteLine("|\t[11] Enter for Pay Bill\t\t   |");
			Console.WriteLine("|\t[0] Enter for  Exit\t\t   |");
			Console.WriteLine("|------------------------------------------|\n");		
			
			Console.Write("Enter Your Choice : ");
			int choice = int.Parse(Console.ReadLine());
			
			switch(choice){
				case 1:
					Console.WriteLine("\n   Welcome SK 7 Stars Pizza");
					Food_Function("Pizza",Pizza);
					break;
				
				case 2:
					Console.WriteLine("\n  Welcome SK 7 Stars Burger");
					Food_Function("Burger",Burger);
					break;
					
				case 3:
					Console.WriteLine("\n  Welcome SK 7 Stars Panipuri");
					Food_Function("Panipuri",Panipuri);
					break;
					
				case 4:
					Console.WriteLine("\n  Welcome SK 7 Stars Sevpuri");
					Food_Function("Sevpori",Sevpuri);
					break;
					
				case 5:
					Console.WriteLine("\n  Welcome SK 7 Stars Samosa");
					Food_Function("Samosa",Samosa);
					break;
					
				case 0:
					Console.WriteLine("\n  Thanks For Visit");
					break;
					
				case 11:
					Pay_Bill = true;
					TOTAL = (total_pizza_price+total_burger_price+total_panipuri_price+total_sevpuri_price+total_samosa_price);
					Console.WriteLine("|-----------------------------------------------|");
					Console.WriteLine("|\t\tFinal Amount Of Bill :-\t\t|");
					Console.WriteLine("|-----------------------------------------------|");	
					Console.WriteLine("|  Description\t|Quantity\t|Price\t|Total  |");
					Console.WriteLine("|-----------------------------------------------|");	
					Console.WriteLine("|Pizza\t\t|{0}\t\t|{1}\t|{2}\t|",Pizza_quantity,Pizza,total_pizza_price);
					Console.WriteLine("|Burger\t\t|{0}\t\t|{1}\t|{2}\t|",Burger_quantity,Burger,total_burger_price);
					Console.WriteLine("|Panipuri\t|{0}\t\t|{1}\t|{2}\t|",Panipuri_quantity,Panipuri,total_panipuri_price);
					Console.WriteLine("|Sevpuri\t|{0}\t\t|{1}\t|{2}\t|",Sevpuri_quantity,Sevpuri,total_sevpuri_price);
					Console.WriteLine("|Samosa\t\t|{0}\t\t|{1}\t|{2}\t|",Samosa_quantity,Samosa,total_samosa_price);
					Console.WriteLine("|-----------------------------------------------|");	
					Console.WriteLine("|\tTotal Amount Of Bill :-\t\t|  "+TOTAL+"\t|");	
					Console.WriteLine("|-----------------------------------------------|");	
					break;
					
				default:
					Console.WriteLine("   Kindly Chose As Above Menu");
					break;
								
			} 
			Console.Write("\nDo You Want To Continue [y/n] : ");
			yn = char.Parse(Console.ReadLine());
			Console.Clear();
		}while(yn == 'y' || yn == 'Y');
		
		if(Pay_Bill == false){
			
			TOTAL = (total_pizza_price+total_burger_price+total_panipuri_price+total_sevpuri_price+total_samosa_price);
			Console.WriteLine("|-----------------------------------------------|");
			Console.WriteLine("|\t\tFinal Amount Of Bill :-\t\t|");
			Console.WriteLine("|-----------------------------------------------|");	
			Console.WriteLine("|  Description\t|Quantity\t|Price\t|Total  |");
			Console.WriteLine("|-----------------------------------------------|");	
			Console.WriteLine("|Pizza\t\t|{0}\t\t|{1}\t|{2}\t|",Pizza_quantity,Pizza,total_pizza_price);
			Console.WriteLine("|Burger\t\t|{0}\t\t|{1}\t|{2}\t|",Burger_quantity,Burger,total_burger_price);
			Console.WriteLine("|Panipuri\t|{0}\t\t|{1}\t|{2}\t|",Panipuri_quantity,Panipuri,total_panipuri_price);
			Console.WriteLine("|Sevpuri\t|{0}\t\t|{1}\t|{2}\t|",Sevpuri_quantity,Sevpuri,total_sevpuri_price);
			Console.WriteLine("|Samosa\t\t|{0}\t\t|{1}\t|{2}\t|",Samosa_quantity,Samosa,total_samosa_price);
			Console.WriteLine("|-----------------------------------------------|");	
			Console.WriteLine("|\tTotal Amount Of Bill :-\t\t|  "+TOTAL+"\t|");	
			Console.WriteLine("|-----------------------------------------------|");	
		}
			Console.ReadLine();
	}
}
