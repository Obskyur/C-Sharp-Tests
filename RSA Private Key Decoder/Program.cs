public class Program
{
    public static void Main()
    {
        Console.WriteLine($"{CalculateD(49, 10539750919)}");
    }

    private static long CalculateD(long e, long n)
    {
        long phi = Totient(n);
        (_, long x, _) = ExtendedGCD(e, phi);
        return x;
    }

    private static long Totient(long n)
    {
        long result = n;
        for (long i = 2; i * i <= n; ++i)
        {
            if (n % i == 0)
            {
                while (n % i == 0)
                {
                    n /= i;
                }
                result -= result / i;
            }
        }
        if (n > 1)
        {
            result -= result / n;
        }
        return result;
    }

    private static (long, long, long) ExtendedGCD(long a, long b)
    {
        if (b == 0)
            return (a, 1, 0);
        else
        {
            (long g, long x, long y) = ExtendedGCD(b, a % b);
            return (g, y, x - (a / b) * y);
        }
    }
}