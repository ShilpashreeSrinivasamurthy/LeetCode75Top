// https://leetcode.com/problems/find-pivot-index/description/?envType=study-plan-v2&envId=leetcode-75

        int PivotIndex(int[] nums)
        {
            int leftSum = 0;
            int rightSum = 0;

            foreach(int num in nums)
            {
                rightSum += num;
            }
            for(int i = 0; i < nums.Length; i++)
            {
                rightSum -= nums[i];
                if(leftSum == rightSum)
                {
                    return i;
                }
                leftSum += nums[i];
            }
            return -1;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
