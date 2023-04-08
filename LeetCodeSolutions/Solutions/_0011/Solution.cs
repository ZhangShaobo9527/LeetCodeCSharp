namespace LeetCodeSolutions.Solutions._0011;

public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;

        int leftWallIndex = 0;
        int rightWallIndex = height.Length - 1;

        while(leftWallIndex < rightWallIndex)
        {
            int areaWidth = rightWallIndex - leftWallIndex;
            int areaHeight = Math.Min(height[leftWallIndex], height[rightWallIndex]);
            int currentArea = areaWidth * areaHeight;
            if(currentArea > maxArea)
            {
                maxArea = currentArea;
            }

            if (height[leftWallIndex] < height[rightWallIndex])
            {
                ++leftWallIndex;
            }
            else
            {
                --rightWallIndex;
            }
        }

        return maxArea;
    }
}
