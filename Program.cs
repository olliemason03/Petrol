
List<bool> forecourt = new List<bool>();


List<car> auto = new List<car>();
void main()
{



    Thread timer = new Thread(que);
    timer.Start();
    que();  

}

void que()
{
    Random rd = new Random();
    int rand_num = rd.Next(1500, 2200);

    Queue<string> queues = new Queue<string> { };

    queues.Enqueue(queue.recievecar());

    string look = queues.Peek();
    Thread.Sleep(rand_num);
    Console.WriteLine(look);
}





Console.ReadKey();