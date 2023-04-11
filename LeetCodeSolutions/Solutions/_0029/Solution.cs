namespace LeetCodeSolutions.Solutions._0029;

public class Solution
{
    /*
        tips: change data type to UInt32 to prevent overflow
    */
    public int Divide(int dividend, int divisor)
    {
        bool resIsNegative = (dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0);
        uint a = Abs(dividend);
        uint b = Abs(divisor);
        uint res = 0;

        while(a >= b)
        {
            uint xCount = 1;
            uint temp = b;

            while(temp < a)
            {
                temp <<= 1;
                xCount <<= 1;
            }

            if (temp > a)
            {
                temp >>= 1;
                xCount >>= 1;
            }

            a -= temp;
            res += xCount;
        }

        if(res > 0x80000000)
        {
            return int.MaxValue;
        }

        if(res == 0x80000000)
        {
            return resIsNegative ? int.MinValue : int.MaxValue;
        }

        return resIsNegative ? 0 - (int)(res) : (int)res;
    }

    private uint Abs(int num)
    {
        if(num == int.MinValue)
        {
            return 0x80000000;
        }

        if(num < 0)
        {
            return (uint)(-num);
        }

        return (uint)num;

    }
}
