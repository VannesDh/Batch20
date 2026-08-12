namespace Exercise3Week2;

public static class Manager
{
    static Stack<string> stack = new();
    
    public static void Type(string word)
    {
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
        Console.WriteLine($"Undid {stack.Peek()}");
        stack.Pop();
    }
}
