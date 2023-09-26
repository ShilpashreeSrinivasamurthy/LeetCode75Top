// https://leetcode.com/problems/container-with-most-water/?envType=study-plan-v2&envId=leetcode-75

int MaxArea(int[] heights)
        {
            int left = 0;
            int right = heights.Length - 1;
            int maxArea = 0;
            while (left < right)
            {
                int height = Math.Min(heights[left], heights[right]);
                int width = right - left;
                int area = height * width;
                maxArea = Math.Max(area, maxArea);
                
                if(heights[left] < heights[right])
                {
                    left++;
                }
                else if (heights[left] > heights[right])
                {
                    right--;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return maxArea;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1
