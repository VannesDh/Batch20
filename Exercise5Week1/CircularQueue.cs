using System;

namespace Exercise5Week1;

public class CircularQueue
{
    private readonly int capacity;
    private readonly int[] arr;
    private int size;
    private int front;


    public CircularQueue(int cap)
    {
        capacity = cap;
        arr = new int[capacity];
        front = 0;
        size = 0;
    }
    public void Log(int val)
    {
        if(size == capacity)
        {
            Console.WriteLine("Buffer Full");
            return;
        }
        int rear = (front + size) % capacity;
        arr[rear] = val;
        size++;
        Console.WriteLine($"Logged {val}");
    }

    public void Read()
    {
        if(size == 0)
        {
            return;
        }
        Console.WriteLine($"Read {arr[front]}");
        arr[front] = default;
        front = (front + 1) % capacity;
        size--;
    }
}


