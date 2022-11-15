public class car
{
 
    public int fuelamountHGV;
    public int fuelamountcar;
    public int fuelamountVan;
    public int randfuel3;
    public int randfuel;
    public int randfuel2;

    public static string diesel = "diesel";

    public static List<String> FuelTypeCar = new List<String> {"Diesel","LPG","unleaded"};
    public static List<String> FuelTypeVan = new List<String> {"Diesel","LPG"};
    public static List<String> type = new List<String> {"HGV","Van","Car"};
    
    public car()
    {   

        
        
    }
    
 
    public static string getFueltypeHGV()
    {
        return diesel;
    }
    public static int getFueltypecar()
    {
        Random rando = new Random();
        int index1 = rando.Next(FuelTypeCar.Count);
        return index1;
    }
    public static void setFuelTypeVan()
    {
        Random rand = new Random();
        int index2 = rand.Next(FuelTypeVan.Count);
        
    }

    public static void setFuelamountCar()
    {
        Random fuelcar = new Random();
            int randfuel = fuelcar.Next(3,50);
        int startcar = randfuel/2;
        
    }
    public static void setFuelamountVan()
    {
        Random fuelVan = new Random();
            int randfuel2 = fuelVan.Next(3,80);
        int startvan = randfuel2/2;
        
    }
    public static void setFuelamountHGV()
    {
        Random fuelHGV = new Random();
            int randfuel3 = fuelHGV.Next(3,150);
            int startHGV = randfuel3/2;
        
    }
}