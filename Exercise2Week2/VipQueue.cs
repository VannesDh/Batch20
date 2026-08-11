namespace Exercise2Week2;

public static class VipQueueManager
{
    readonly static LinkedList<string> queue = new();

    public static void Enqueue(string str)
    {
        queue.AddLast(str);
        Console.WriteLine($"Queued {str}");
    }

    public static void Process()
    {
         if(queue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        Console.WriteLine($"Process {queue.First?.Value}");
        queue.RemoveFirst();
    }

    public static void EnqueueVip(string str)
    {
        queue.AddFirst(str);
        Console.WriteLine($"VIP Queued {str}");
    }
}