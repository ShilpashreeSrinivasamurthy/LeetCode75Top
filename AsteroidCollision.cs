// https://leetcode.com/problems/asteroid-collision/?envType=study-plan-v2&envId=leetcode-75

       int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (stack.Count > 0 && asteroids[i]  < 0 && stack.Peek() > 0)
                {
                    if(Math.Abs(asteroids[i]) == Math.Abs(stack.Peek()))
                    {
                        stack.Pop();
                    }
                    else if (Math.Abs(asteroids[i]) > Math.Abs(stack.Peek()))
                    {
                        stack.Pop();
                        i--;
                    }
                }
                else
                {
                    stack.Push(asteroids[i]);
                }
            }

            int[] result = new int[stack.Count];
            int count = 0;
            while(stack.Count > 0)
            {
                result[count] = stack.Pop();
                count++;
            }
            return result;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
