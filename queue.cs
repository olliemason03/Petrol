class queue
{  
    public string cars;
    public int qQuant;

    
    public queue(string c)
    {
        this.cars = c;
    }

    public static string recievecar()
    {
        List<string> type = new List<string>{"HGV","Van","Car"};
       
        Random random = new Random();
            int index = random.Next(type.Count); 


        string ind = type[index].ToString();
        return ind;
        
    }

}