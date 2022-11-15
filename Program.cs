
List<car> auto = new List<car>();


Random rd = new Random();
    int rand_num = rd.Next(1500,2200);
Timer myTimer = new Timer(test,null,0,rand_num);


static void test(object o)
{      
    

    Queue<string> queues = new Queue<string>{};

    queues.Enqueue(queue.recievecar());
    string look = queues.Peek();



    
       
}
Console.WriteLine("pump 1 : " + " pump 4: "  + "pump 7: ");
Console.WriteLine("pump 2 : " + " pump 5: " + "pump 8: ");
Console.WriteLine("pump 3 : " + " pump 6: " + "pump 9: ");




Console.ReadKey();