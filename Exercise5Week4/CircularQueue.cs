namespace Exercise5Week4;

public class CircularQueue
{
    private int capacity;
    private int[] arr;
    private int size;
    private int front;
    private bool isOverwriteEnabled;

    private const int WarningPercentage = 66;
    private const int CriticalPercentage = 100;

    public CircularQueue(int cap)
    {
        capacity = cap;
        arr = new int[capacity];
        front = 0;
        size = 0;
        isOverwriteEnabled = true;
    }

    public void SetCapacity(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("Capacity must be greater than 0.");
        }

        capacity = n;
        arr = new int[capacity];

        // Reset existing data
        front = 0;
        size = 0;

        Console.WriteLine($"Capacity set to {capacity}");
    }

    public void SetOverwritePolicy(bool isOverwriteEnabled)
    {
        this.isOverwriteEnabled = isOverwriteEnabled;

        Console.WriteLine(
            isOverwriteEnabled
                ? "Overwrite policy enabled."
                : "Overwrite policy disabled."
        );
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

        // Buffer is full
        if (size == capacity)
        {
            if (isOverwriteEnabled)
            {
                arr[front] = val;

                Console.WriteLine($"Overwritten oldest with {val}");

                front = (front + 1) % capacity;
            }
            else
            {
                Console.WriteLine($"Buffer Full: Rejected {val}");
            }

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