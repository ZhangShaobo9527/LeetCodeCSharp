using System;
using System.Collections.Generic;
using System.Linq;

using LeetCodeSolutions.Definitions;

namespace LeetCodeSolutions.Solutions._0005;

public class Solution
{
    /*
    classic DP problem, let's create an 2D array, and let:
        matrix[i][j] == s[i..j] is palindrome or not
    */
    public string LongestPalindrome(string s)
    {
        bool?[,] matrix = new bool?[s.Length, s.Length];

        int longestPalindromeStartIndex = 0;
        int longestPalindromeLength = 0;

        for(int j = 0; j < s.Length; ++j)
        {
            for(int i = j; i >= 0; --i)
            {
                if (s[i] == s[j])
                {
                    if(i == j || i + 1 == j || i + 2 == j)
                    {
                        matrix[i, j] = true;
                    }
                    else if (matrix[i+1, j-1]!.Value)
                    {
                        matrix[i, j] = true;
                    }
                    else
                    {
                        matrix[i, j] = false;
                    }
                }
                else
                {
                    matrix[i, j] = false;
                }

                if (matrix[i, j]!.Value)
                {
                    if(j - i + 1 > longestPalindromeLength)
                    {
                        longestPalindromeLength = j - i + 1;
                        longestPalindromeStartIndex = i;
                    }
                }
            }
        }

        return s.Substring(longestPalindromeStartIndex, longestPalindromeLength);
    }
}
