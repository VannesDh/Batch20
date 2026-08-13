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

    public static void PrintReverse()
    {
        stringBuilder.Clear();
        int[] temp = [.. linkedList];

        for (int i = temp.Length-1; i >= 0; i--)
        {
            if (temp[i] != linkedList.First())
            {
                stringBuilder.Append($"{temp[i]} -> ");
            }
            else
            {
                stringBuilder.Append($"{temp[i]}");
            }
        }
        Console.WriteLine(stringBuilder.ToString());
    }
    public static void Print()
    {
        stringBuilder.Clear();
        foreach (int value in linkedList)
        {
            if (value != linkedList.Last())
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
