

using System.Timers;

Random randtime = new Random();
int random = randtime.Next(1500, 2200);

Random randomtime = new Random();
int randomT = randomtime.Next(1000, 2000);




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



var interval = new System.Timers.Timer(randomT);



Random randv = new Random();
Random randf = new Random();
Random randfv = new Random();
Random randomf = new Random();
Random randomf2 = new Random();
Random randomf3 = new Random();
Random lanerand = new Random();
Random newpump = new Random();
Random lanes = new Random();

string password = "";
string username = "";
int queueLim = 5;
string ft = "";
int f = 0;

Queue<vehicle> pumps = new Queue<vehicle>();

void main()
{

    Console.WriteLine("Welcome to Broken Petrol Ltd.");
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("\n\nplease Login");
    Console.WriteLine("USERNAME = 'cashier'");
    Console.WriteLine("PASSWORD = 'login'");
    try
    {
        Console.WriteLine("Username: ");
        string username = Console.ReadLine();
    }
    catch
    {
        if (username != "cashier")
        {
            Console.WriteLine("incorrect username");
            main();
        }
    }
    try
    {
        Console.WriteLine("password: ");
        string password = Console.ReadLine();

    }
    catch
    {
        if (password != "login")
        {
            Console.WriteLine("incorrect password...");
            main();
        }
    }

    Console.Clear();

    Thread add = new Thread(AddVehicle);
    add.Start();






}
main();
void pumpdisplay()
{
    Console.WriteLine(laneOne[0] + " " + laneOne[0].getStatus() + " " + laneTwo[0] + " " + laneTwo[0].getStatus() + " " + laneThree[0] + " " + laneOne[0].getStatus());
    Console.WriteLine(laneOne[1] + " " + laneOne[1].getStatus() + " " + laneTwo[1] + " " + laneTwo[0].getStatus() + " " + laneThree[1] + " " + laneOne[0].getStatus());
    Console.WriteLine(laneOne[2] + " " + laneOne[2].getStatus() + " " + laneTwo[2] + " " + laneTwo[0].getStatus() + " " + laneThree[2] + " " + laneOne[0].getStatus());
}
void pumpsNo()
{




    int lane = newpump.Next(0, 3);
    int knewpump = lanes.Next(0, 3);

    switch (lane)
    {
        case 0:
            switch (knewpump)
            {
                case 0:
                    laneOne[0].setStatus(stat);
                    Thread.Sleep(randomT);
                    
                    laneOne[0].setStatus(s);

                    break;
                case 1:
                    laneOne[1].setStatus(stat);
                    Thread.Sleep(randomT);
                    laneOne[1].setStatus(s);


                    break;
                case 2:
                    laneOne[2].setStatus(stat);
                    Thread.Sleep(randomT);
                    laneOne[2].setStatus(s);


                    break;
            }
            break;
        case 1:
            switch (knewpump)
            {
                case 0:
                    laneTwo[0].setStatus(stat);
                    Thread.Sleep(randomT);
                    laneTwo[0].setStatus(s);

                    break;
                case 1:
                    laneTwo[1].setStatus(stat);
                    Thread.Sleep(randomT);
                    laneTwo[1].setStatus(s);


                    break;
                case 2:
                    laneTwo[2].setStatus(stat);
                    Thread.Sleep(randomT);
                    laneTwo[2].setStatus(s);


                    break;
            }
            break;
        case 2:
            switch (knewpump)
            {
                case 0:
                    laneThree[0].setStatus(stat);
                    Thread.Sleep(randomT);
                    laneThree[0].setStatus(s);

                    break;
                case 1:
                    laneThree[1].setStatus(stat);
                    Thread.Sleep(randomT);
                    laneThree[1].setStatus(s);

                    break;
                case 2:
                    laneThree[2].setStatus(stat);
                    Thread.Sleep(randomT);
                    laneThree[2].setStatus(s);

                    break;
            }
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
            }
            else if (vehicletype[Vvalue].Equals("Van"))
            {
                int fvValue = randfv.Next(1, 3);
                ft = fueltype[fvValue];
                int randomvanf = (randomf2.Next(2, 80)) / 2;
                f = randomvanf;
            }
            else
            {
                ft = fueltype[2];
                int randomHGVf = (randomf3.Next(2, 150)) / 2;
                f = randomHGVf;
            }
            vehicle v1 = new vehicle(f, ft, vehicletype[Vvalue]);
            Thread.Sleep(random);
            Console.Clear();

            pumps.Enqueue(v1);
            foreach (vehicle v in pumps)
            {

                Console.WriteLine(v.getVehicleType() + " " + v.getFuelType() + " " + v.Getfuel() + "L");

            }

        }
        else if (pumps.Count >= queueLim)
        {
            pumpdisplay();
            pumps.Dequeue();
            pumpsNo();

        }



    }
    Thread service = new Thread(pumpsNo);
    service.Start();

}




Console.ReadKey();