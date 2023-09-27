// https://leetcode.com/problems/successful-pairs-of-spells-and-potions/?envType=study-plan-v2&envId=leetcode-75

        int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            int[] successfulPairs = new int[spells.Length];
            Array.Sort(potions);
            for(int i = 0; i < spells.Length; i++)
            {
                int left = 0;
                int right = potions.Length - 1;
                while(left <= right)
                {
                    int mid = left + (right - left) / 2;
                    long product = potions[mid] * spells[i];
                    if(product >= success)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                successfulPairs[i] = potions.Length - left;
            }
            return successfulPairs;
        }
        // Time Complexity : O(n log m) where n is the length of spells and m is the length of potions
        // Space Complexity : O(1)
