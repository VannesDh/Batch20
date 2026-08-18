namespace Exercise2Week3;

public static class PriorityQueue
{

    class Node
    {
        public string Value;
        public int Priority;

        public Node(string value, int priority)
        {
            Value = value;
            Priority = priority;
        }
    }
    readonly static LinkedList<Node> queue = new();

    public static void Enqueue(string str, int p)
    {
        queue.AddLast(new Node(str, p));
        Console.WriteLine($"Queued {str} with Priority {p}");
    }

    public static void Process()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node? highestPriorityNode = null;

        foreach (Node node in queue)
        {
            if (highestPriorityNode == null ||
                node.Priority > highestPriorityNode.Priority)
            {
                highestPriorityNode = node;
            }
        }

        Console.WriteLine($"Process {highestPriorityNode?.Value}");
        queue.Remove(highestPriorityNode);
    }
}