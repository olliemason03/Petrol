class vehicle
{
    int fuel = 0;
    string fuelType;
    string vehicleType;
    
    int amount;
    double fuelcost;

    public vehicle(int f, string ft, string vt,int a,double fc)
    {
        this.fuel = f;
        this.fuelType = ft;
        this.vehicleType = vt;
        this.amount = a;
        this.fuelcost = fc;
        
    }
    
    public int Getfuel()
    {
        return fuel;
    }
    public string getFuelType()
    {
        return fuelType;
    }
    public string getVehicleType()
    {
        return vehicleType;
        
    }
    public int GetAmount()
    {
        return amount;
    }
    public double GetFuelCost()
    {
        return fuelcost;
    }
}