// https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/?envType=study-plan-v2&envId=leetcode-75

        bool[] KidsWithCandies(int[] candies, int extraCandies)
        {
            int maxCandyCount = candies.ToList().Max<int>();
            bool[] isMax = new bool[candies.Length];
            for (int i = 0; i < candies.Length; i++)
            {
                isMax[i] = candies[i] + extraCandies >= maxCandyCount;
            }
            return isMax;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
