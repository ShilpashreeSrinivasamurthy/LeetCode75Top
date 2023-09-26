// https://leetcode.com/problems/max-number-of-k-sum-pairs/description/?envType=study-plan-v2&envId=leetcode-75

        int MaxOperations(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int operationCount = 0;
            foreach(int num in nums)
            {
                if(dict.ContainsKey(k - num) && dict[k - num] > 0)
                {
                    dict[k - num]--;
                    operationCount++;
                }
                else
                {
                    if (!dict.ContainsKey(num))
                    {
                        dict[num] = 0;
                    }
                    dict[num]++;
                }
            }
            return operationCount;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
