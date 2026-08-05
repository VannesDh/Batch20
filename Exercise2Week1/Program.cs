using System.Collections;
using System.Diagnostics;

namespace Exercise2Week1;

class Exercise2
{
    static void Main()
    {
        QueueProcess queueProcess = new();
        queueProcess.Enqueue("A");
        queueProcess.Enqueue("B");
        queueProcess.Process();
        queueProcess.Process();
        queueProcess.Process();
    }
}

class QueueProcess()
{
    private Queue _queue = new();

    public void Enqueue(object obj)
    {
        Console.WriteLine("Queued {0}",obj);
        _queue.Enqueue(obj);
    }

    public void Process()
    {
        if(_queue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("Processed {0}", _queue.Peek());
            _queue.Dequeue();
        }
    }
}

