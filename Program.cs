
Random randtime = new Random();
int random = randtime.Next(1500, 2200);


Thread service = new Thread(assignpump);
service.Start();





string[] vehicletype = new string[] { "Car", "Van", "HGV" };
string[] fueltype = new string[] { "Unleaded", "LPG", "Diesel" };

string[] laneOne = new string[] { "pump 1 ", "pump 4 ", "pump 7" };
string[] lanetwo = new string[] { "pump 2 ", "pump 5 ", "pump 8" };
string[] laneThree = new string[] { "pump 3 ", "pump 6 ", "pump 9" };

Queue<vehicle> pumps = new Queue<vehicle>();



Random randv = new Random();
Random randf = new Random();
Random randfv = new Random();
Random randomf = new Random();
Random randomf2 = new Random();
Random randomf3 = new Random();
Random lanerand = new Random();
Random newpump = new Random();

int queueLim = 5;
string ft;
int f = 0;
bool status = true, status4 =true, status7 = true;
bool status2 = true, status5 = true, status8=true;
bool status3 = true, status6 = true, status9 = true;
string l="";
Thread add = new Thread(AddVehicle);
add.Start();


void pumpdisplay()
{
    Console.Clear();
    Console.WriteLine(laneOne[0] + " = " + status + " " + lanetwo[0] + " = " + status4 + " " + laneThree[0] + " = " + status7);
    Console.WriteLine(laneOne[1] + " = " + status2 + " " + lanetwo[1] + " = " + status5 + " "+ laneThree[1] + " = " + status8);
    Console.WriteLine(laneOne[2] + " = " + status3 + " " + lanetwo[2] + " = " + status6 + " " + laneThree[2] + " = " + status9);
    
}
void AddVehicle(object o)
{


    


   
    while (pumps.Count <= queueLim)
    {
        pumpdisplay();

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
            
            pumps.Enqueue(v1);
            foreach (vehicle v in pumps)
            {

                Console.WriteLine(v.getVehicleType() + " " + v.getFuelType() + " " + v.Getfuel() + "L");
                


            }
        }
        else if (pumps.Count >= queueLim)
        {
            pumps.Dequeue();
            
            assignpump(o);


        }
        
        
        
    }

}

void assignpump(object o)
{

    int lane = newpump.Next(0, 3);

    if (lane == 0)
    {
        l = laneOne[0];
        if (l == laneOne[0])
        {
            status = false;
            Thread.Sleep(1000);
            
            
        }
        else if (Thread.Sleep(1000)== true && l == laneOne[0])
        {
            l = lanetwo[1];
            status4 = false;
        }
        else if(status == false && l==lanetwo[1])
        {
            l= laneOne[2];
            status5 = false;
        }


    }
    if (lane == 1)
    {
        l = lanetwo[0];
        if (l == lanetwo[0])
        {
            status2 = false;
            
        }
        else if (status == false && l == lanetwo[0])
        {
            l = lanetwo[1];
            status5 = false;
        }
        else if(status == false && l==lanetwo[1])
        {
            l= lanetwo[2];
            status8 = false;
        }


    }
    if (lane == 2)
    {
        l = laneThree[0];
        if (l == laneThree[0])
        {
            status3 = false;
            
        }
        else if (status == false && l == laneThree[0])
        {
            l = laneThree[1];
            status6 = false;
        }
        else if(status == false && l==laneThree[1])
        {
            l= laneThree[2];
            status9 = false;
        }


    }

    
    pumps pumpz = new pumps(status, l);



}




Console.ReadKey();