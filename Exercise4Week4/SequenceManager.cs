using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4Week4;

public class SequenceManager
{
    private readonly LinkedList<int> linkedList = new();
    private readonly StringBuilder stringBuilder = new();
    private readonly List<Func<int, bool>> filters = new();
    private Func<int, int, int>? comparer;

    public void SetSorting(Func<int, int, int> comparer)
    {
        this.comparer = comparer;
    }

    public void AddFilter(Func<int, bool> filterRule)
    {
        filters.Add(filterRule);
    }

    public void Append(int val)
    {
        if (comparer == null)
        {
            linkedList.AddLast(val);
        }
        else
        {
            LinkedListNode<int>? current = linkedList.First;

            while (current != null && comparer(current.Value, val) < 0)
            {
                current = current.Next;
            }

            if (current == null)
            {
                linkedList.AddLast(val);
            }
            else
            {
                linkedList.AddBefore(current, val);
            }
        }

        Console.WriteLine($"Appended {val}");
    }

    private IEnumerable<int> FilteredValues()
    {
        return linkedList.Where(v => filters.All(f => f(v)));
    }

    public void PrintReverse()
    {
        stringBuilder.Clear();
        int[] temp = [.. FilteredValues()];

        for (int i = temp.Length - 1; i >= 0; i--)
        {
            if (i != 0)
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

    public void Print()
    {
        stringBuilder.Clear();
        int[] temp = [.. FilteredValues()];

        for (int i = 0; i < temp.Length; i++)
        {
            if (i != temp.Length - 1)
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
}