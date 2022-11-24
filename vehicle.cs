class vehicle
{
    int fuel = 0;
    string fuelType;
    string vehicleType;
    

    public vehicle(int f, string ft, string vt)
    {
        this.fuel = f;
        this.fuelType = ft;
        this.vehicleType = vt;
        
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

}