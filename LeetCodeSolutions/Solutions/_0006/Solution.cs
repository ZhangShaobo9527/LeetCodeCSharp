using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCodeSolutions.Definitions;

namespace LeetCodeSolutions.Solutions._0006;

public class Solution
{
    /*
        I'm gonna draw the ZigZag instead of using any formula

        it's simple and intuitive.

        to save memory, I'm gonna using SortedDictionary as the canvas

            /--column 1
            |   /-- column 2
            |   |   /-- column 3
            P   A   H   N ----------row 1
            A P L S I I G ----------row 2
            Y   I   R     ----------row 3
    */
    public string Convert(string s, int numRows)
    {
        if(numRows == 1)
        {
            return s;
        }

        SortedDictionary<int, SortedDictionary<int, char>> canvas = new SortedDictionary<int, SortedDictionary<int, char>>();

        bool up = false;
        int currentRow = 1;
        int currentColumn = 1;

        foreach(char c in s)
        {
            PutCharIntoCanvas(currentRow, currentColumn, c, canvas);

            if(currentRow == numRows)
            {
                up = true;
            }

            if(currentRow == 1)
            {
                up = false;
            }

            if(up)
            {
                currentRow--;
                currentColumn++;
            }
            else
            {
                currentRow++;
            }
        }

        StringBuilder sb = new StringBuilder();
        foreach(var row in canvas.Values)
        {
            foreach(var c in row.Values)
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

    private void PutCharIntoCanvas(int row, int column, char c, SortedDictionary<int, SortedDictionary<int, char>> canvas)
    {
        if (!canvas.ContainsKey(row))
        { 
            canvas.Add(row, new SortedDictionary<int, char>());
        }

        canvas[row][column] = c;
    }
}
