namespace Exercise3Week3;

public static class Manager
{
    static Stack<string> stack = new();
    static Stack<string> undoStack = new();
    
    public static void Type(string word)
    {
        undoStack.Clear();
        if(stack.Count >= 3)
        {
            Stack<string> temp = new();
            while (stack.Count > 1)
            {
                temp.Push(stack.Pop());
            }
            stack.Pop();
            stack = temp;
            stack.Push(word);
            Console.WriteLine($"Dropped Bottom, Typed {stack.Peek()}");
        }
        else
        {            
            stack.Push(word);
            Console.WriteLine($"Typed {stack.Peek()}");
        }
    }

    public static void Undo()
    {
        string lastElement = stack.Peek();
        undoStack.Push(lastElement);
        Console.WriteLine($"Undid {lastElement}");
        stack.Pop();
    }

    public static void Redo()
    {
        string lastElement = undoStack.Pop();
        stack.Push(lastElement);
        Console.WriteLine($"Redid {lastElement}");
    }
}
