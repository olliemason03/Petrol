
Random rd = new Random();
    int rand_num = rd.Next(1500,2200);

String[] Vehicle = new String[] {"HGV","Van","Car"};
Timer myTimer = new Timer(test,null,0,rand_num);

void test(object o)
{
    Random random = new Random();
    String[] Vehicle = new String[] {"HGV","Van","Car"};

	int index = random.Next(Vehicle.Length);
	String entry = Vehicle[index]; 
			if(entry.Equals("Car"))
			{
				Random fuel = new Random();
				  double rand_fuel1 = fuel.Next(0,50);
                Random FuelType = new Random();
                  string rand_type = FuelType.Next("Unleaded", "Diseal", "LPG");
                
				Console.WriteLine(entry + "("+rand_type+")" + rand_fuel1+"L");

		
			}
			else if(entry.Equals("HGV"))
			{
				Random fuel = new Random();
				  double rand_fuel2 = fuel.Next(0,150);
                  Random FuelType = new Random();
                   string rand_type2 = FuelType.Next("Diseal", "LPG");
				Console.WriteLine(entry + "("+rand_type2+")" + rand_fuel2+"L");  

			}
			else if(entry.Equals("Van"))
			{
				Random fuel = new Random();
				  double rand_fuel3 = fuel.Next(0,50);
             
				Console.WriteLine(entry + "(Diseal)   " + rand_fuel3+"L");
			}
}
           




Console.ReadKey();