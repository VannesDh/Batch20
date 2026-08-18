using System.Text;

namespace Exercise1Week3;


class FooBar
{
    public static string Generate(int n)
    {
        StringBuilder sb = new();

        for (int i = 1; i <= n; i++)
        {
            if(i % 3 == 0)
                sb.Append("foo");
            if(i % 4 == 0)
                sb.Append("baz");
            if(i % 5 == 0)
                sb.Append("bar");
            if(i % 7 == 0)
                sb.Append("jazz");
            if(i % 9 == 0)
                sb.Append("huzz");
        
            if (i % 3 != 0 && i % 4 != 0 && i % 5 != 0 && i % 7 != 0 && i % 9 != 0)
                sb.Append(i);

            if (i != n)
                sb.Append(", ");
        }

        return sb.ToString();
    }
}