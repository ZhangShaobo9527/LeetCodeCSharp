namespace LeetCodeSolutions.Solutions._0004;

public class Solution
{
    /*
    --------- step 1:
        let's assume:
            numsAll = MERGE(nums1, nums2)
        and let:
            lengthAll = numsAll.Length
            length1   = nums1.Length
            length2   = nums2.Length
        then: 
            answer == numsAll[(lengthAll-1)/2] + numsAll[lengthAll/2]

        example 1:
            if
                numsAll = {1,2,3,4}
            then
                answer  = (numsAll[(4-1)/2] + numsAll[4/2])/2
                        = (numsAll[1] + numsAll[2]) / 2
                        = (2 + 3) / 2
                        = 2.5
        example 2:
            if
                numsAll = {1,2,3,4,5}
            then
                answer  = (numsAll[(5-1)/2] + numsAll[5/2])/2
                        = (numsAll[2] + numsAll[2]) / 2
                        = 3
    ---------- step 2:
        now split numsAll into 2 parts: left & right, which:
            left        = numsAll[0           .. lengthAll/2 - 1]
            right       = numsAll[lengthAll/2 .. lengthAll - 1  ]
        also:
            lengthLeft  == (length1 + length2) / 2
            lengthRight == (length1 + length2 + 1) / 2
        so:
            answer == left.Length == right.Length ? (left.Last() + right.First()) / 2 : right.First()

        example 1:
            if
                numsAll = {1,2,3,4}
            then
                left        = numsAll[0   .. 4/2-1] = [0 .. 1] = {1, 2}
                right       = numsAll[4/2 .. 4-1  ] = [2 .. 3] = {3, 4}
                lengthLeft  == (2 + 2) / 2     == 2;
                lengthRight == (2 + 2 + 1) / 2 == 2;
                answer      == (2 + 3) / 2     == 2.5

        example 2:
            if
                numsAll = {1,2,3,4,5}
            then
                left        = numsAll[0   .. 5/2-1] = [0 .. 1] = {1, 2}
                right       = numsAll[5/2 .. 5-1  ] = [2 .. 4] = {3, 4, 5}
                lengthLeft  == (2 + 3) / 2     == 2
                lengthRight == (2 + 3 + 1) / 2 == 3
                answer      == 3
                
    ---------- step 3:
        let's assume again:
            x = count of numbers which originally belongs to "nums1", but now belongs to "left"
            y = count of numbers which originally belongs to "nums2", but now belongs to "left"
        then we got:
            left  == MERGE(nums1[0 .. x - 1      ], nums2[0 .. y - 1      ])
            right == MERGE(nums1[x .. length1 - 1], nums2[y .. length2 - 1])
            lengthLeft  == x + y
            lengthRight == length1 + length2 - x - y
        and because
            x + y == lengthLeft == (length1 + length2) / 2
        so
            y == (length1 + length2) / 2 -x
            left  == MERGE(nums1[0 .. x - 1      ], nums2[0                           .. (length1 + length2) / 2 - x - 1])
            right == MERGE(nums1[x .. length1 - 1], nums2[(length1 + length2) / 2 - x .. length2 - 1                    ])
        so
            if: x + y == length1 + length2 - x - y
                answer == (left.Last() + right.First()) / 2
                       == (MAX(nums1[x - 1], nums2[y                           - 1]) + MIN(nums1[x], nums2[y                          ])) / 2
                       == (MAX(nums1[x - 1], nums2[(length1 + length2) / 2 - x - 1]) + MIN(nums1[x], nums2[(length1 + length2) / 2 - x])) / 2
            else:
                answer == right.First()
                       == MIN(nums1[x], nums2[y                         ])
                       == MIN(nums1[x], nums2[(length + length2) / 2 - x])
        
        and x could be any value between [0 .. length1]
        so the problem became: find the right x
        
        then this problem became a binary-search problem

    ---------- tips:
        and because the possible range of x is [0 .. length1]
        so let the nums1 become the shorter one could optimize the search process
    */
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            int[] tmp = nums1;
            nums1 = nums2;
            nums2 = tmp;
        }

        if (nums1.Length == 0)
        {
            if (nums2.Length == 0)
            {
                return 0.0;
            }

            return (nums2[(nums2.Length - 1) / 2] + nums2[nums2.Length / 2]) / 2.0;
        }

        int leftBoundOfX = 0;
        int rightBoundOfX = nums1.Length;

        while (leftBoundOfX <= rightBoundOfX)
        {
            int x = (leftBoundOfX + rightBoundOfX) / 2;
            int y = (nums1.Length + nums2.Length) / 2 - x;

            int leftNumsAll_Last;
            int rightNumsAll_First;

            if (x == 0)
            {
                leftNumsAll_Last = nums2[y - 1];
                rightNumsAll_First = (y == nums2.Length) ? nums1[x] : Math.Min(nums1[x], nums2[y]);
            }
            else if (x == nums1.Length)
            {
                leftNumsAll_Last = (y == 0) ? nums1[x - 1] : Math.Max(nums1[x - 1], nums2[y - 1]);
                rightNumsAll_First = nums2[y];
            }
            else
            {
                rightNumsAll_First = Math.Min(nums1[x], nums2[y]);
                leftNumsAll_Last = Math.Max(nums1[x - 1], nums2[y - 1]);
            }

            if (leftNumsAll_Last > rightNumsAll_First)
            {
                if (x == 0 || nums2[y - 1] > nums1[x])
                {
                    leftBoundOfX = x + 1;
                }
                else if (x == nums1.Length || nums1[x - 1] > nums2[y])
                {
                    rightBoundOfX = x - 1;
                }
            }
            else
            {
                if ((nums1.Length + nums2.Length) % 2 == 0)
                {
                    return (leftNumsAll_Last + rightNumsAll_First) / 2.0;
                }
                else
                {
                    return rightNumsAll_First;
                }
            }
        }

        return 0.0;
    }
}
