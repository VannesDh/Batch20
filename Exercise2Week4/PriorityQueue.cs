namespace Exercise2Week4;

public class PriorityQueue
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

    private readonly LinkedList<Node> queue = new();
    private readonly Dictionary<string, int> rules = new();

    public void AddRule(string keyword, int priority)
    {
        rules[keyword] = priority;
    }

    public void Enqueue(string val)
    {
        int priority = 0;

        foreach (var rule in rules)
        {
            if (val.Contains(rule.Key, StringComparison.OrdinalIgnoreCase))
            {
                priority = rule.Value;
                break;
            }
        }

        queue.AddLast(new Node(val, priority));

        Console.WriteLine($"Queued {val} with priority {priority}");
    }

    public void Process()
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

        Console.WriteLine($"Process {highestPriorityNode.Value}");
        queue.Remove(highestPriorityNode);
    }
}