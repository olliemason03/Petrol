

using System.Timers;

Random randtime = new Random();
int random = randtime.Next(1500, 2200);

Random randomtime = new Random();
int randomT = randomtime.Next(1000, 2000);

Random randomQ = new Random();
int Queuez = randomQ.Next(5,9);




string s = "available";
string stat = "busy";

List<pumps> laneOne = new List<pumps>();
for (int i = 0; i < 3; i++)
{
    pumps pump1 = new pumps(s);
    laneOne.Add(pump1);
}
List<pumps> laneTwo = new List<pumps>();
for (int i = 0; i < 3; i++)
{
    pumps pump1 = new pumps(s);
    laneTwo.Add(pump1);
}
List<pumps> laneThree = new List<pumps>();
for (int i = 0; i < 3; i++)
{
    pumps pump1 = new pumps(s);
    laneThree.Add(pump1);
}




string[] vehicletype = new string[] { "Car", "Van", "HGV" };
string[] fueltype = new string[] { "Unleaded", "LPG", "Diesel" };






Random randv = new Random();
Random randf = new Random();
Random randfv = new Random();
Random randomf = new Random();
Random randomf2 = new Random();
Random randomf3 = new Random();
Random lanerand = new Random();
Random newpump = new Random();
Random lanes = new Random();


int queueLim = Queuez;
string ft = "";
int f = 0;
int count = 0;
int amount = 0;
double fuelcost = 0;
double countfuel = 0;
string choice= "";

double countcost = 0;
double cashierwage = 0;


System.Timers.Timer NewTime = new System.Timers.Timer(random);

Queue<vehicle> pumps = new Queue<vehicle>();

void main()
{
    setup();
    NewTime.Elapsed += NewTime_Elapsed;
    NewTime.Enabled = true;
    NewTime.AutoReset = true;
}
main();

void NewTime_Elapsed(object sender, ElapsedEventArgs e)
{
    pumpsNo();
}


void setup()
{

    Console.WriteLine("Welcome to Broken Petrol Ltd.");
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("\n\nplease Login");
    

    Console.WriteLine("Username: ");
    string username = Console.ReadLine();
    if (username.Equals("cashier"))
    {

        Console.WriteLine("password: ");
        string password = Console.ReadLine();
        if (password.Equals("login"))
        {
            Console.Clear();

            Thread add = new Thread(AddVehicle);
            add.Start();
            NewTime.Start();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid password...Please check");
            setup();

        }

    }
    else
    {
        Console.Clear();
        Console.WriteLine("invalid username...please check");
        setup();
    }




}



void pumpdisplay()
{

    Console.Clear();
    Console.WriteLine(laneOne[0] + " " + laneOne[0].getStatus() + " " + laneTwo[0] + " " + laneTwo[0].getStatus() + " " + laneThree[0] + " " + laneOne[0].getStatus());
    Console.WriteLine(laneOne[1] + " " + laneOne[1].getStatus() + " " + laneTwo[1] + " " + laneTwo[0].getStatus() + " " + laneThree[1] + " " + laneOne[0].getStatus());
    Console.WriteLine(laneOne[2] + " " + laneOne[2].getStatus() + " " + laneTwo[2] + " " + laneTwo[0].getStatus() + " " + laneThree[2] + " " + laneOne[0].getStatus());



    Console.WriteLine("\n\nTotal Vehicles Serviced: " + count);
    Console.WriteLine("\nTotal Fuel sold: £" + countcost);
    Console.WriteLine("\n1% commission rate: £" + cashierwage);
    Console.WriteLine("End Shift? y/n");
    choice = Console.ReadLine();
    if(choice=="y")
    {
        end();
    }

    
}
void end()
{
    Console.WriteLine("total cars serviced today: " + count);
    Console.WriteLine("Thank you for your services! \n here is your commission:\n " + cashierwage);

    Console.WriteLine("Do you wish to login ?... y/n");
    string option = Convert.ToString(Console.ReadLine());
    if (option == "y")
    {
        setup();
    }
    else
    {

    }
}
async void pumpsNo()
{
    int lane = newpump.Next(0, 3);
    int knewpump = lanes.Next(0, 3);

    switch (lane)
    {
        case 0:

            laneOne[knewpump].setStatus(stat);
            await Task.Delay(randomT);
            laneOne[knewpump].setStatus(s);
            break;

        case 1:

            laneTwo[knewpump].setStatus(stat);
            await Task.Delay(randomT);
            laneTwo[knewpump].setStatus(s);
            break;

        case 2:

            laneThree[knewpump].setStatus(stat);
            await Task.Delay(randomT);
            laneThree[knewpump].setStatus(s);
            break;
    }

}
void AddVehicle()
{
    while (pumps.Count <= queueLim)
    {

        if (pumps.Count < queueLim)
        {
            int fvalue = randf.Next(0, 3);
            int Vvalue = randv.Next(0, 3);
            if (vehicletype[Vvalue].Equals("Car"))
            {
                ft = fueltype[fvalue];
                int randomcarf = (randomf.Next(2, 50)) / 2;
                f = randomcarf;
                if (fueltype[fvalue].Equals("Unleaded"))
                {
                    fuelcost = (50 - randomcarf) * 0.145;
                }
                else if (fueltype[fvalue].Equals("LPG"))
                {
                    fuelcost = (50 - randomcarf) * 0.150;
                }
                else
                {
                    fuelcost = (50 - randomcarf) * 0.172;

                }

            }
            else if (vehicletype[Vvalue].Equals("Van"))
            {
                int fvValue = randfv.Next(1, 3);
                ft = fueltype[fvValue];
                int randomvanf = (randomf2.Next(2, 80)) / 2;
                f = randomvanf;
                if (fueltype[fvalue].Equals("LPG"))
                {
                    fuelcost = (80 - randomvanf) * 0.150;

                }
                else
                {
                    fuelcost = (80 - randomvanf) * 0.172;

                }

            }
            else
            {
                ft = fueltype[2];
                int randomHGVf = (randomf3.Next(2, 150)) / 2;
                f = randomHGVf;
                fuelcost = (150 - randomHGVf) * 0.172;


            }

            vehicle v1 = new vehicle(f, ft, vehicletype[Vvalue], amount, fuelcost);
            Thread.Sleep(random);

            Console.Clear();

            pumps.Enqueue(v1);
            foreach (vehicle v in pumps)
            {
                amount++;

                Console.WriteLine(v.getVehicleType() + " " + v.getFuelType() + " " + v.Getfuel() + "L");
                count = v.GetAmount();
                pumpsNo();
                countfuel = v.GetFuelCost();


            }

        }
        else if (pumps.Count >= queueLim)
        {
            pumps.Dequeue();


        }
        pumpdisplay();

        for (int i = 0; i <= countfuel; i++)
        {
            countcost = countcost + i;
        }
        cashierwage = countcost / 100;

    }


}




Console.ReadKey();