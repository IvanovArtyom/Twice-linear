using System.Collections.Generic;
using System.Linq;

public class DoubleLinear
{
    public static void Main()
    {
        // Test
        var t = DblLinear(10);
        // ...should return 22
    }

    public static int DblLinear(int n)
    {
        int x = 1;
        SortedSet<int> sequence = new() { x };

        for (int i = 0; i <= n; i++)
        {
            x = sequence.ElementAt(0);
            sequence.Remove(x);
            sequence.Add(2 * x + 1);
            sequence.Add(3 * x + 1);
        }

        return x;
    }
}