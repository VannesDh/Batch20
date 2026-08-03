using System.Text;

namespace Exercise1;

class Exercise1
{
    static void Main()
    {
        Console.Write(Generate(15));
    }

    public static string Generate(int n)
    {
        StringBuilder stringBuilder = new();

        for(int i = 1 ; i <= n ; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                stringBuilder.Append("foobar");
            }
            else if(i % 3 == 0)
            {
                stringBuilder.Append("foo");
            }
            else if(i % 5 == 0)
            {
                stringBuilder.Append("bar");
            }
            else
            {
                stringBuilder.Append(i);
            }

            if(i != n)
            {
                stringBuilder.Append(", ");
            }
        }
        return stringBuilder.ToString();
    }
}
