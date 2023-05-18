namespace LeetCodeSolutions.Solutions._0050;

public class Solution
{
    /*
        key point is : 
            pow(x, 100) == pow(x * x, 50) == pow(x * x * x * x, 25)
    */
    public double MyPow(double x, int n)
    {
        // why long? because abs(int.MinValue) will overflow
        long absN = Math.Abs((long)(n));
        double absX = Math.Abs(x);

        if(doubleEquals(0, absX))
        {
            return 0;
        }

        if(doubleEquals(1, absX))
        {
            if(x > 0)
            {
                return 1;
            }

            if((n & 1) == 1)
            {
                return -1;
            }

            return 1;
        }

        double res = 1;

        while(absN != 0)
        {
            if((absN & 1) == 1)
            {
                res *= x;
            }

            absN >>= 1;

            x *= x;
        }

        return n < 0 ? 1.0 / res : res;
    }

    private bool doubleEquals(double a, double b)
    {
        return Math.Abs(a - b) < 0.0000000001;
    }
}
