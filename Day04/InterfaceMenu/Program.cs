public enum Menu{
	Nasi,
	Ayam,
	Indomie,
	Burger,
	Pizza,
	EsTeh
}

class Program{
	static void Main(){
		void nasiCheck(Menu order){
			if(order == Menu.Nasi){
				Console.WriteLine("Pesan Nasi");
			}
			Console.WriteLine("Bukan Nasi");
		}
		
		Menu orderFood = Menu.Nasi;
		Console.WriteLine(orderFood);
		nasiCheck(orderFood);
	}
}

	
