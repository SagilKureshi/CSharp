
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
	static char payment;
	static int Pizza_total_quantity;
	static int Burger_total_quantity;
	static int Panipuri_total_quantity;
	static int Sevpuri_total_quantity;
	static int Samosa_total_quantity;
	static float TOTAL;
	static float DISCOUNT;
	static float GST;
	static float FINAL;
	static bool Pay_Bill = false;
	
	static void Food_Function(string name,int price){
		Console.WriteLine("|-----------------------------|");
		Console.WriteLine("|   Description   |   Price   |");
		Console.WriteLine("|-----------------------------|");
		Console.WriteLine("|   {0}\t  |    {1}    |",name,price);
		Console.WriteLine("|-----------------------------|");
		Bill(name,price);	
	}
	
	static void Bill(string name,int price){
		
		if(price == 499){
			Console.Write("\nEnter Quantity Of Your Order : ");
			Pizza_quantity = int.Parse(Console.ReadLine());
			Pizza_total_quantity += Pizza_quantity;
			total_pizza_price = (Pizza_total_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Pizza_total_quantity,price,total_pizza_price);
		}
		else if(price == 299){
			Console.Write("\nEnter Quantity Of Your Order : ");
			Burger_quantity = int.Parse(Console.ReadLine());
			Burger_total_quantity += Burger_quantity;
			total_burger_price = (Burger_total_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Burger_total_quantity,price,total_burger_price);
		}
		else if(price == 199){
			Console.Write("\nEnter Quantity Of Your Order : ");
			Panipuri_quantity = int.Parse(Console.ReadLine());
			Panipuri_total_quantity += Panipuri_quantity;
			total_panipuri_price = (Panipuri_total_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t{1}\t\t{2}\t{3}",name,Panipuri_total_quantity,price,total_panipuri_price);
		}
		else if(price == 209){
			Console.Write("\nEnter Quantity Of Your Order : ");
			Sevpuri_quantity = int.Parse(Console.ReadLine());
			Sevpuri_total_quantity += Sevpuri_quantity;
			total_sevpuri_price = (Sevpuri_total_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Sevpuri_total_quantity,price,total_sevpuri_price);
		}
		else{
			Console.Write("\nEnter Quantity Of Your Order : ");
			Samosa_quantity = int.Parse(Console.ReadLine());
			Samosa_total_quantity += Samosa_quantity;
			total_samosa_price = (Samosa_total_quantity*price);
			Console.WriteLine("\t***Your Bill***");
			Console.WriteLine("Description\tQuantity\tPrice\tTotal");
			Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}",name,Samosa_total_quantity,price,total_samosa_price);
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
			Console.WriteLine("|\t[11] Enter for Pay The Bill\t   |");
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
					Food_Function("Sevpuri",Sevpuri);
					break;
					
				case 5:
					Console.WriteLine("\n  Welcome SK 7 Stars Samosa");
					Food_Function("Samosa",Samosa);
					break;
					
				case 11:
				
					TOTAL = (total_pizza_price+total_burger_price+total_panipuri_price+total_sevpuri_price+total_samosa_price);
					DISCOUNT = (TOTAL/10);
					GST = (TOTAL*18)/100;
					FINAL = (TOTAL-DISCOUNT+GST);	
					Console.WriteLine("|-----------------------------------------------|");
					Console.WriteLine("|\t\tFinal Amount Of Bill :-\t\t|");
					Console.WriteLine("|-----------------------------------------------|");	
					Console.WriteLine("|  Description\t|Quantity\t|Price\t|Total  |");
					Console.WriteLine("|-----------------------------------------------|");	
					Console.WriteLine("|Pizza\t\t|{0}\t\t|{1}\t|{2}\t|",Pizza_total_quantity,Pizza,total_pizza_price);
					Console.WriteLine("|Burger\t\t|{0}\t\t|{1}\t|{2}\t|",Burger_total_quantity,Burger,total_burger_price);
					Console.WriteLine("|Panipuri\t|{0}\t\t|{1}\t|{2}\t|",Panipuri_total_quantity,Panipuri,total_panipuri_price);
					Console.WriteLine("|Sevpuri\t|{0}\t\t|{1}\t|{2}\t|",Sevpuri_total_quantity,Sevpuri,total_sevpuri_price);
					Console.WriteLine("|Samosa\t\t|{0}\t\t|{1}\t|{2}\t|",Samosa_total_quantity,Samosa,total_samosa_price);
					TOTAL = (total_pizza_price+total_burger_price+total_panipuri_price+total_sevpuri_price+total_samosa_price);
					Console.WriteLine("|-----------------------------------------------|");	
					Console.WriteLine("|\t\t\t\t\t|  "+TOTAL+"\t|");	
					Console.WriteLine("|-----------------------------------------------|");	
					Console.WriteLine("|\t10% Discount :-\t\t\t|- "+DISCOUNT+" |");	
					Console.WriteLine("|-----------------------------------------------|");	
					Console.WriteLine("|\t18% GST :-\t\t\t|+ "+GST+"|");	
					Console.WriteLine("|-----------------------------------------------|");	
					Console.WriteLine("|\tTotal Amount Of Bill :-\t\t|"+FINAL+" |");	
					Console.WriteLine("|-----------------------------------------------|");	
					if(TOTAL != 0){
						Console.Write("\nDo You Want To Pay The Bill [y/n] : ");
						payment = char.Parse(Console.ReadLine());
						if(payment == 'y' || payment == 'Y')
							Pay_Bill = true;
					}
					break;					
				
				case 0:
					Console.WriteLine("\n  Thanks For Visit");
					break;
					
				default:
					Console.WriteLine("   Kindly Chose As Above Menu");
					break;
								
			} 
			if(Pay_Bill == true)
				break;
			Console.Write("\nDo You Want To Continue [y/n] : ");
			yn = char.Parse(Console.ReadLine());
			Console.Clear();
		}while(yn == 'y' || yn == 'Y');
		
		if(Pay_Bill == false){
			Console.WriteLine("|-----------------------------------------------|");
			Console.WriteLine("|\t\tFinal Amount Of Bill :-\t\t|");
			Console.WriteLine("|-----------------------------------------------|");	
			Console.WriteLine("|  Description\t|Quantity\t|Price\t|Total  |");
			Console.WriteLine("|-----------------------------------------------|");	
			Console.WriteLine("|Pizza\t\t|{0}\t\t|{1}\t|{2}\t|",Pizza_total_quantity,Pizza,total_pizza_price);
			Console.WriteLine("|Burger\t\t|{0}\t\t|{1}\t|{2}\t|",Burger_total_quantity,Burger,total_burger_price);
			Console.WriteLine("|Panipuri\t|{0}\t\t|{1}\t|{2}\t|",Panipuri_total_quantity,Panipuri,total_panipuri_price);
			Console.WriteLine("|Sevpuri\t|{0}\t\t|{1}\t|{2}\t|",Sevpuri_total_quantity,Sevpuri,total_sevpuri_price);
			Console.WriteLine("|Samosa\t\t|{0}\t\t|{1}\t|{2}\t|",Samosa_total_quantity,Samosa,total_samosa_price);
			TOTAL = (total_pizza_price+total_burger_price+total_panipuri_price+total_sevpuri_price+total_samosa_price);
			DISCOUNT = (TOTAL/10);	
			GST = (TOTAL*18)/100;
			FINAL = (TOTAL-DISCOUNT+GST);
			Console.WriteLine("|-----------------------------------------------|");	
			Console.WriteLine("|\t\t\t\t\t|  "+TOTAL+"\t|");	
			Console.WriteLine("|-----------------------------------------------|");	
			Console.WriteLine("|\t10% Discount :-\t\t\t|- "+DISCOUNT+" |");	
			Console.WriteLine("|-----------------------------------------------|");	
			Console.WriteLine("|\t18% GST :-\t\t\t|+ "+GST+"|");	
			Console.WriteLine("|-----------------------------------------------|");	
			Console.WriteLine("|\tTotal Amount Of Bill :-\t\t|"+FINAL+" |");	
			Console.WriteLine("|-----------------------------------------------|");	
		}
			Console.WriteLine("Thanks For Visit\nComes Again With Your Family");
			Console.ReadLine();
	}
}
