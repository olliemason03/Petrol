class vehicle
{
    int fuel = 0;
    string fuelType;
    string vehicleType;
    
    double fuelfilled;
    int amount;
    double fuelcost;

    public vehicle(int f, string ft, string vt,int a,double fc,double ff)
    {
        this.fuel = f;
        this.fuelType = ft;
        this.vehicleType = vt;
        this.amount = a;
        this.fuelcost = fc;
        this.fuelfilled = ff;
        
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
    public double getFuelFilled()
    {
        return fuelfilled;
    }
}