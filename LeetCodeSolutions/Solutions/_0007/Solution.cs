using System;
using System.Collections.Generic;
using System.Linq;

using LeetCodeSolutions.Definitions;

namespace LeetCodeSolutions.Solutions._0007;

public class Solution
{
    public int Reverse(int x)
    {
        int res = 0;

        while(x != 0)
        {
            int digit = x % 10;

            if(res > 0 && res > (int.MaxValue - digit) / 10)
            {
                return 0;
            }

            if(res < 0 && res < (int.MinValue - digit) / 10)
            {
                return 0;
            }

            res *= 10;
            res += digit;

            x /= 10;
        }

        return res;
    }
}
