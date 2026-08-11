namespace Exercise2Week2;

public class Program
{
   public static void Main()
    {
     VipQueueManager.Enqueue("A");
     VipQueueManager.Enqueue("B");
     VipQueueManager.EnqueueVip("C");
     VipQueueManager.Process();
     VipQueueManager.Process();
     VipQueueManager.Process();
    }
}


