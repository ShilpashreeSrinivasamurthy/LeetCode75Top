// https://leetcode.com/problems/increasing-triplet-subsequence/?envType=study-plan-v2&envId=leetcode-75
        bool IncreasingTriplets(int[] nums)
        {
            int first = Int32.MaxValue;
            int second = Int32.MaxValue;
            foreach(int num in nums)
            {
                if(num <= first)
                {
                    first = num;
                }
                else if(num <= second)
                {
                    second = num;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
