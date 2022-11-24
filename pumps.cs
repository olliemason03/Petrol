class pumps
{
    public string status = "Available";

    
    public pumps(string s)
    {
        this.status = s;
        

    }


    public string getStatus()
    {
        return status;
    }

    public string setStatus(string s)
    {
        this.status = s;
    }


}