using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

using LeetCodeSolutions.Definitions;

namespace LeetCodeSolutions.Solutions._0008;

public class Solution
{
    /*
        not very hard, but very gross.
        
        there are several things you need to carefully handle:
            1. leading space
            2. positive/negative char
            3. tailing non-numeric character
            4. overflow
            5. the god damn empty string and string full of spaces
    
    */
    public int MyAtoi(string s)
    {
        int res = 0;
        bool haveMetAtLeastOneDigit = false;
        bool haveMetTheSignCharacter = false;
        bool negative = false;


        for (int index = 0; index < s.Length; ++index)
        {
            bool isDigit = s[index] >= '0' && s[index] <= '9';
            bool isSpace = s[index] == ' ';
            bool isSignCharacter = s[index] == '+' || s[index] == '-';

            if(!isDigit && !isSpace && !isSignCharacter)
            {
                break;
            }

            if(isDigit)
            {
                int digit = s[index] - '0';

                if (res > int.MaxValue / 10)
                {
                    return negative ? int.MinValue : int.MaxValue;
                }

                if (res == int.MaxValue / 10)
                {
                    if (negative && digit >= Math.Abs((int.MinValue % 10)))
                    {
                        return int.MinValue;
                    }

                    if (!negative && digit >= int.MaxValue % 10)
                    {
                        return int.MaxValue;
                    }
                }


                res *= 10;
                res += s[index] - '0';

                haveMetAtLeastOneDigit = true;
            }

            if(isSpace)
            {
                if(haveMetAtLeastOneDigit || haveMetTheSignCharacter)
                {
                    break;
                }
            }

            if(isSignCharacter)
            {
                if(haveMetAtLeastOneDigit || haveMetTheSignCharacter)
                {
                    break;
                }

                haveMetTheSignCharacter = true;
                negative = s[index] == '-';
            }
        }

        return negative ? -res : res;
    }
}
