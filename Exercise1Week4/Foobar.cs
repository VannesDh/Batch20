using System.Text;

namespace Exercise1Week4;

public class FooBar
{
    private readonly List<(int Divisor, string Output)> _rules = new();

    public void AddRule(int divisor, string output)
    {
        _rules.Add((divisor, output));
        _rules.Sort((a, b) => a.Divisor.CompareTo(b.Divisor));
    }

    public string Evaluate(int number)
    {
        StringBuilder sb = new();

        foreach (var rule in _rules)
        {
            if (number % rule.Divisor == 0)
            {
                sb.Append(rule.Output);
            }
        }

        if (sb.Length == 0)
        {
            sb.Append(number);
        }

        return sb.ToString();
    }

    public string GenerateSequence(int start, int end)
    {
        StringBuilder sb = new();

        for (int i = start; i <= end; i++)
        {
            sb.Append(Evaluate(i));

            if (i != end)
            {
                sb.Append(", ");
            }
        }

        return sb.ToString();
    }
}