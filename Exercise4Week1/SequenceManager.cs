using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceManager;

public static class Manager
{
    public static readonly LinkedList<int> linkedList = new();
    public static readonly StringBuilder stringBuilder = new();

    public static void Append(int val)
    {
        linkedList.AddLast(val);
        Console.WriteLine($"Appended {val}");

    }

    public static void Print()
    {
        foreach(int value in linkedList)
        {
            if(value != linkedList.Last())
            {
                stringBuilder.Append($"{value} -> ");
            }
            else
            {
                stringBuilder.Append($"{value}");
            }
        }
        Console.WriteLine(stringBuilder.ToString());
    }
}
