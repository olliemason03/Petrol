class vehicle
{
 
    public int fuelamountHGV;
    public int fuelamountcar;
    public int fuelamountVan;
    public int randfuel3;
    public int randfuel;
    public int randfuel2;



    public List<String> FuelTypeCar = new List<String> {"Diseal","LPG","unleaded"};
    public String[] FuelTypeVan = new String[] {"Diseal","LPG"};
    public static String[] type = new String[] {"HGV","Van","Car"};
    
    
    
    public static void setType()
    {
    
        Random random = new Random();
        int index = random.Next(type.Length);
        string StrIndex = type[index];
        
    }
    public int getFueltypecar()
    {
        Random rando = new Random();
        int index1 = rando.Next(FuelTypeCar.Length);
        return index1;
    }
    public void setFuelTypeVan()
    {
        Random rand = new Random();
        int index2 = rand.Next(FuelTypeVan.Length);
        
    }

    public void setFuelamountCar()
    {
        Random fuelcar = new Random();
            int randfuel = fuelcar.Next(0,50);
        
    }
    public void setFuelamountVan()
    {
        Random fuelVan = new Random();
            int randfuel2 = fuelVan.Next(0,80);
        
    }
    public void setFuelamountHGV()
    {
        Random fuelHGV = new Random();
            int randfuel3 = fuelHGV.Next(0,50);
        
    }
}