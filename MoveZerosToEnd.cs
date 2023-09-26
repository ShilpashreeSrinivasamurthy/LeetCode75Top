//https://leetcode.com/problems/move-zeroes/description/?envType=study-plan-v2&envId=leetcode-75

void MoveZerosToEnd(int[] nums)
        {
            int index = 0;
            foreach(int num in nums)
            {
                if(num != 0)
                {
                    nums[index] = num;
                    index++;
                }
            }
            while(index < nums.Length)
            {
                nums[index] = 0;
                index++;
            }

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
         }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
