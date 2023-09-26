// https://leetcode.com/problems/find-the-highest-altitude/?envType=study-plan-v2&envId=leetcode-75

        int LargestAltitude(int[] gain)
        {
            int currentAltitude = 0;
            int maxAltitude = 0;
            foreach(int altitide in gain)
            {
                currentAltitude += altitide;
                maxAltitude = Math.Max(currentAltitude, maxAltitude);
            }
            return maxAltitude;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
