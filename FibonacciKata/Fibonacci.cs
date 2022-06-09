namespace FibonacciKata;

public class Fibonacci
{
    public static int GetNumber(int number)
    {
        if (number == 0)
            return 0;
        if (number == 1)
            return 1;
        return GetNumber(number - 1) + GetNumber(number - 2);
    }
}