namespace Exercise5Week3;

public class CircularQueue
{
    private readonly int capacity;
    private readonly int[] arr;
    private int size;
    private int front;

    private const int WarningPercentage = 66;
    private const int CriticalPercentage = 100;

    public CircularQueue(int cap)
    {
        capacity = cap;
        arr = new int[capacity];
        front = 0;
        size = 0;
    }

    public void Log(int val)
    {
        int currentPercentage = size * 100 / capacity;

        if (currentPercentage >= CriticalPercentage)
        {
            Console.WriteLine("Critical: Buffer Full");
        }
        else if (currentPercentage >= WarningPercentage)
        {
            Console.WriteLine("Warning: Buffer at 66%");
        }

        if (size == capacity)
        {
            arr[front] = val;
            Console.WriteLine($"Overwritten oldest with {val}");
            front = (front + 1) % capacity;
            return;
        }

        int rear = (front + size) % capacity;
        arr[rear] = val;
        size++;

        Console.WriteLine($"Logged {val}");
    }

    public void Read()
    {
        if (size == 0)
        {
            return;
        }

        Console.WriteLine($"Read {arr[front]}");
        arr[front] = default;
        front = (front + 1) % capacity;
        size--;
    }
}