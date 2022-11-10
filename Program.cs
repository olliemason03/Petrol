
List<vehicle> auto = new List<vehicle>();



    Random rd = new Random();
        int rand_num = rd.Next(1500,2200);
    Timer myTimer = new Timer(test,null,0,rand_num);
    
void test(object o);
{   
    Console.WriteLine(vehicle.setType());

}




Console.ReadKey();