// https://leetcode.com/problems/maximum-average-subarray-i/?envType=study-plan-v2&envId=leetcode-75

        double FindAverage (int[] nums, int k)
        {
            int sum = 0;
            double maxSum;
            for(int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            maxSum = sum;

            for(int i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];
                maxSum = Math.Max(sum, maxSum);
            }
            maxSum /= k;
            return maxSum;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
