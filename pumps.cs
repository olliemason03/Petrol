class pumps
{
    public bool status;
    public string name;
    
    public pumps(bool s, string n)
    {
        this.status = s;
        this.name = n;

    }

    public string getName()
    {
        return name;
    }
    public bool getStatus()
    {
        return status;
    }




}