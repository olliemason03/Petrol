
Random randtime = new Random();
int random = randtime.Next(1500, 2200);
string[] vehicletype = new string[] { "Car", "Van", "HGV" };
string[] fueltype = new string[] { "unleaded", "lpg", "diesel" };

string[] laneOne = new string[] {"pump 1 ", "pump 4 ", "pump 7"};
string[] lanetwo = new string[] {"pump 2 ", "pump 5 ", "pump 8"};
string[] laneThree = new string[] {"pump 3 ", "pump 6 ", "pump 9"};

List<pumps> lane1 = new List<pumps>(3);
List<pumps> lane2 = new List<pumps>(3);
List<pumps> lane3 = new List<pumps>(3);


Random randv = new Random();
Random randf = new Random();
Random randfv = new Random();
Random randomf = new Random();
Random randomf2 = new Random();
Random randomf3 = new Random();
Random lanerand = new Random();

int queueLim = 5;
string i;
int f = 0;
Thread add = new Thread(AddVehicle);
add.Start(1);

void AddVehicle(object o)
{
    List<pumps> myPumps;
    int lane = Convert.ToInt32(o);   
    if(lane==1)
    {
         myPumps = new List<pumps>(lane1);
    }
    if(lane==2)
    {
         myPumps = new List<pumps>(lane2);
    }
    if(lane==3)
    {
         myPumps = new List<pumps>(lane3);
    }
   // myPumps.Add();
    Queue<vehicle> pumps = new Queue<vehicle>();
    while (pumps.Count<=queueLim)
    {

        
        if (pumps.Count < queueLim)
        {
            int fvalue = randf.Next(0, 3);
            int Vvalue = randv.Next(0, 3);
            if (vehicletype[Vvalue].Equals("Car"))
            {
                i = fueltype[fvalue];
                int randomcarf = (randomf.Next(2, 50)) / 2;
                f = randomcarf;
            }
            else if (vehicletype[Vvalue].Equals("Van"))
            {
                int fvValue = randfv.Next(1, 3);
                i = fueltype[fvValue];
                int randomvanf = (randomf2.Next(2, 80)) / 2;
                f = randomvanf;
            }
            else
            {
                i = fueltype[2];
                int randomHGVf = (randomf3.Next(2, 150)) / 2;
                f = randomHGVf;
            }
            vehicle v1 = new vehicle(f, i, vehicletype[Vvalue]);
            Thread.Sleep(random);
            Console.Clear();
            pumps.Enqueue(v1);
            foreach (vehicle v in pumps)
            {
                Console.WriteLine(v.getVehicleType());
            }

        }
        else if (pumps.Count >= queueLim)
        {
            pumps.Dequeue();
            v1 = lanerand.Next()

        }
    }
}






Console.ReadKey();