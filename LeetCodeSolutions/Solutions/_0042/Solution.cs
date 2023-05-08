namespace LeetCodeSolutions.Solutions._0042;

public class Solution
{
    public int Trap(int[] height)
    {
        int totalWater = 0;

        int highestBlockIdx = 0;
        int highestBlockHeight = 0;

        for(int i = 0; i < height.Length; ++i)
        {
            if (height[i] > highestBlockHeight)
            {
                highestBlockIdx = i;
                highestBlockHeight = height[i];
            }
        }

        int maxHeightSoFar = 0;

        for(int i = 0; i < highestBlockIdx; ++i)
        {
            if (height[i] > maxHeightSoFar)
            {
                maxHeightSoFar = height[i];
                continue;
            }

            totalWater += maxHeightSoFar - height[i];
        }

        maxHeightSoFar = 0;

        for(int i = height.Length - 1; i > highestBlockIdx; --i)
        {
            if (height[i] > maxHeightSoFar)
            {
                maxHeightSoFar = height[i];
                continue;
            }

            totalWater += maxHeightSoFar - height[i];
        }

        return totalWater;
    }
}
