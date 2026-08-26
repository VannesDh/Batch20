namespace Exercise3Week4;

public class History
{
    private Stack<string> stack = new();
    private Stack<string> undoStack = new();
    private List<Func<string, bool>> validationRules = new();

    public void AddValidationRule(Func<string, bool> rule)
    {
        validationRules.Add(rule);
    }

    public void Type(string word)
    {
        foreach (var rule in validationRules)
        {
            if (!rule(word))
            {
                Console.WriteLine($"Rejected {word}");
                return;
            }
        }

        undoStack.Clear();

        if (stack.Count >= 3)
        {
            Stack<string> temp = new();

            while (stack.Count > 1)
            {
                temp.Push(stack.Pop());
            }

            stack.Pop();

            stack = temp;
            stack.Push(word);

            Console.WriteLine($"Dropped Bottom, Typed {word}");
        }
        else
        {
            stack.Push(word);
            Console.WriteLine($"Typed {word}");
        }
    }

    public void Undo()
    {
        if (stack.Count == 0)
            return;

        string lastElement = stack.Pop();
        undoStack.Push(lastElement);

        Console.WriteLine($"Undid {lastElement}");
    }

    public void Redo()
    {
        if (undoStack.Count == 0)
            return;

        string lastElement = undoStack.Pop();
        stack.Push(lastElement);

        Console.WriteLine($"Redid {lastElement}");
    }
}