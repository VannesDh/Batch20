namespace Exercise3Week1;

public static class Manager
{
    static readonly Stack<string> stack = new();
    
    public static void Type(string word)
    {
        stack.Push(word);
        Console.WriteLine($"Typed {stack.Peek()}");
    }

    public static void Undo()
    {
        Console.WriteLine($"Undid {stack.Peek()}");
        stack.Pop();
    }
}
