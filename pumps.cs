class pumps
{
    public bool status;
    public string name;

    public pumps(bool s, string n)
    {
        this.status = s;
        this.name = n;

    }

    string setName()
    {
        return name;
    }
    bool setStatus()
    {
        return status;
    }




}