// https://leetcode.com/problems/single-number/?envType=study-plan-v2&envId=leetcode-75

int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result ^= num;
            }
            return result;
        }
