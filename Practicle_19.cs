	using System;
	class SK_Watches_Menu{
		static string Rolex_Name = "Rolex Daytona Paul Newman 6239";
		static string Omega_Name = "Omega vintage Speedmaster Ref. 2915-1";
		static string Patek_Name = "Patek Philippe Grandmaster Chime Ref. 6300A-010	";
		static string Titan_Name = "Titan Nebula Jalsa\t|\t4000000 (4.05 million INR)";
		static string Casio_Name = "CASIO G-SHOCK Men Watc";
		static int Rolex_price = 32411568;
		static long Patek_price = 2600000000;
		static int Rolex_quant = 0;
		static int Patek_quant = 0; 
		static int Omega_price = 277664000;
		static int Omega_quant = 0;
		static int Titan_price = 4000000;
		static int Titan_quant = 0;
		static int Casio_price = 49995;
		static int Casio_quant = 0;
		static long Total =0;
		static char ny;
		static char buy;
			
		static void Total_bill(int quantity,string Name,long price){
			Console.WriteLine("|---------------------------------");
			Console.WriteLine("NO.\tDescription\t\t\tPrice");
			Console.WriteLine("{0}. {1} \t {2}",quantity,Name,price);
			Console.WriteLine("\n\nTotal Amount:-\t\t\t  "+Total);
			Console.WriteLine("|---------------------------------");
		}
		
		static void Rolex_fun(){
			Rolex_quant++;
			Console.WriteLine("|----------------------------------------------------------------------------------------------|");
			Console.WriteLine("|\t\t\t\tWelcome to SK Rolex Watches :-                                 |");	
			Console.WriteLine("|----------------------------------------------------------------------------------------------|");
			Console.WriteLine("|   Quantity\t\t\t|\t\tModel\t         |\t   Price(INR)\t       |");
			Console.WriteLine("|----------------------------------------------------------------------------------------------|");
			Console.WriteLine("|      {0} Rolex Daytona Paul Newman 6239 |  32,411,568($17.75 million) |",Rolex_quant+"\t\t\t|");	
			Console.WriteLine("|----------------------------------------------------------------------------------------------|");
			Console.Write("\nDo you want to Purchase [y/n] : ");
			buy = char.Parse(Console.ReadLine());
			if(buy == 'y' || buy == 'Y'){

				Total += Rolex_price;
				Total_bill(Rolex_quant,Rolex_Name,Rolex_price);
			}else{
				Rolex_quant--;
				Console.WriteLine("Thank for visit");
			}
		}	
		
		static void Patek_fun(){
			Patek_quant++;
			Console.WriteLine("|----------------------------------------------------------------------------------------------|");		
			Console.WriteLine("|\t\t\t   Welcome to SK Patek_Philippe Watches :- \t\t\t       |");
			Console.WriteLine("|----------------------------------------------------------------------------------------------|");		
			Console.WriteLine("|Quantity   |\t\t\t   Model\t\t\t\t|\tPrice(INR)     |");
			Console.WriteLine("|----------------------------------------------------------------------------------------------|");		
			Console.WriteLine("|{0}\t    |\tPatek Philippe Grandmaster Chime Ref. 6300A-010	\t|\t260 crore      |",Patek_quant);	
			Console.WriteLine("|----------------------------------------------------------------------------------------------|");		
			Console.Write("\nDo you want to Purchase [y/n] : ");
			buy = char.Parse(Console.ReadLine());
			if(buy == 'y' || buy == 'Y'){
				Total +=  Patek_price;
				Total_bill(Patek_quant,Patek_Name,Patek_price);	
			}else{
				Patek_quant--;
				Console.WriteLine("Thanks for visit");	
			}
		}
		
		static void Omega_fun(){
			Omega_quant++;
			Console.WriteLine("|----------------------------------------------------------------------------------------------------------|");
			Console.WriteLine("|\t\t\t\tWelcome to SK Omega Watches :-\t\t\t\t\t\t   |");
			Console.WriteLine("|----------------------------------------------------------------------------------------------------------|");
			Console.WriteLine("|Quantity   |\t\t\t     Model\t\t\t   |\t\t  Price(INR)\t\t   |");
			Console.WriteLine("|----------------------------------------------------------------------------------------------------------|");
			Console.WriteLine("|{0}\t    |\t     	Omega vintage Speedmaster Ref. 2915-1\t   |\t  27,76,64,000($17.75 million)\t   |",Omega_quant);	
			Console.WriteLine("|----------------------------------------------------------------------------------------------------------|");
			Console.Write("\nDo you want to Purchase [y/n] : ");
			buy = char.Parse(Console.ReadLine());
			if(buy == 'y' || buy == 'Y'){
				Total +=Omega_price;
				Total_bill(Omega_quant,Omega_Name,Omega_price);
			}else{
				Omega_quant--;
				Console.WriteLine("Thanks for Visit \n");
			}
		
		}
		
		static void Titan_fun(){
			Titan_quant++;
			Console.WriteLine("|-------------------------------------------------------------------------------------|");
			Console.WriteLine("|\t\t\tWelcome to SK Titan Watches :-\t\t\t\t      |");
			Console.WriteLine("|-------------------------------------------------------------------------------------|");
			Console.WriteLine("| Quantity |\t\tModel\t\t|\t\tPrice(INR)\t\t      |");
			Console.WriteLine("|-------------------------------------------------------------------------------------|");
			Console.WriteLine("|    {0}\t   |\t Titan Nebula Jalsa\t|\t4000000 (4.05 million INR)\t      |",Titan_quant);
			Console.WriteLine("|-------------------------------------------------------------------------------------|");
			Console.Write("\nDo you want to Purchase [y/n] : ");
			buy = char.Parse(Console.ReadLine());
			if(buy == 'y' || buy == 'Y'){

				Total += Titan_price;
				Total_bill(Titan_quant,Titan_Name,Titan_price);
			}else{
				Titan_quant--;
				Console.WriteLine("Thanks for Visit \n");
			}
			
		}
		
		static void Casio_fun(){
			Casio_quant++;
			Console.WriteLine("|------------------------------------------------------------------------------------|");
			Console.WriteLine("|\t\t\tWelcome to SK Casio Watches :-\t\t\t\t     |");
			Console.WriteLine("|------------------------------------------------------------------------------------|");
			Console.WriteLine("| Quantity\t|\t\tModel\t    	   |\t\tPrice(INR)\t     |");
			Console.WriteLine("|------------------------------------------------------------------------------------|");
			Console.WriteLine("|    {0}\t\t|\tCASIO G-SHOCK Men Watc     |\t\t49995\t\t     |",Casio_quant);	
			Console.WriteLine("|------------------------------------------------------------------------------------|");
			Console.Write("\nDo you want to Purchase [y/n] : ");
			buy = char.Parse(Console.ReadLine());
			if(buy == 'y' || buy == 'Y'){

				Total += Casio_price;
				Total_bill(Casio_quant,Casio_Name,Casio_price);
			}else{
				Casio_quant--;
				Console.WriteLine("Thanks for Visit \n");
			}
			
		}
				
		static void Main(){
			char yn;
				
			do{
				Console.WriteLine("***** Most Welcome To The Luxury SK Watches :- *****\n");
				Console.WriteLine("********* SK Watches Menu :- *********\n");			
				Console.WriteLine("Press [1] for Rolex Watches");
				Console.WriteLine("Press [2] for Patek Philippe Watches");
				Console.WriteLine("Press [3] for Omega Watches");
				Console.WriteLine("Press [4] for Titan Watches");
				Console.WriteLine("Press [5] for Casio Watches");
				Console.WriteLine("Press [0] for out to the watch shope\n");
					
				Console.Write("Your Choice : ");
				int choice = int.Parse(Console.ReadLine());
					
				switch(choice){
					case 1:
						Rolex_fun();
						if(buy == 'y' || buy == 'Y'){
							Console.Write("\nDo you want to add more quantity [y/n] : ");
							ny = char.Parse(Console.ReadLine());
						}
						if(ny == 'y' || ny == 'Y')
							Rolex_fun();
						break;
						
					case 2:
						Patek_fun();
						if(buy == 'y' || buy == 'Y'){
							Console.Write("\nDo you want to add more quantity [y/n] : ");
							ny = char.Parse(Console.ReadLine());
						}
						if(ny == 'y' || ny == 'Y')
							Patek_fun();	
						break;
						
					case 3:
						Omega_fun();
						if(buy == 'y' || buy == 'Y'){
							Console.Write("\nDo you want to add more quantity [y/n] : ");
							ny = char.Parse(Console.ReadLine());
						}
						if(ny == 'y' || ny == 'Y')
							Omega_fun();
						break;
						
					case 4:
						Titan_fun();
						if(buy == 'y' || buy == 'Y'){
							Console.Write("\nDo you want to add more quantity [y/n] : ");
							ny = char.Parse(Console.ReadLine());
						}
						if(ny == 'y' || ny == 'Y')
							Titan_fun();
						break;
						
					case 5:
						Casio_fun();
						if(buy == 'y' || buy == 'Y'){
							Console.Write("\nDo you want to add more quantity [y/n] : ");
							ny = char.Parse(Console.ReadLine());
						}
						if(ny == 'y' || ny == 'Y')
							Casio_fun();
						break;
						
					case 0:
						Console.WriteLine("Thanks to visit ");
									break;
						
					default:
						Console.WriteLine("Please Select Your Option Related Above Menu");
						break;
				}
				Console.Write("Do you want to Continue Press [y/n] : ");
				yn = char.Parse(Console.ReadLine());
				Console.Clear();
			}while(yn == 'y' ||yn == 'Y');
			Console.WriteLine();
		}
	}
