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

    public void setStatus(string st)
    {
        this.status = st;
        //return st;
    }


}