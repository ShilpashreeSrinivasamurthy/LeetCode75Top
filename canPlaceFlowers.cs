// https://leetcode.com/problems/can-place-flowers/description/?envType=study-plan-v2&envId=leetcode-75

        bool CanPlaceFlowers(int[] flowerBed, int n)
        {
            if(n == 0)
            {
                return true;
            }
            int count = 0;
            for(int i = 0; i < flowerBed.Length && count < n; i++)
            {
                if (flowerBed[i] == 0)
                {
                    int previousSpot = (i == 0) ? 0 : flowerBed[i - 1];
                    int nextSpot = (i == flowerBed.Length - 1) ? 0 : flowerBed[i + 1];

                    if (previousSpot == 0 && nextSpot == 0)
                    {
                        flowerBed[i] = 1;
                        count++;
                    }
                }
            }
            return count == n;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
