// https://leetcode.com/problems/counting-bits/?envType=study-plan-v2&envId=leetcode-75

        int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 1; i < result.Length; i++)
            {
                if (i % 2 == 0)
                    result[i] = result[i / 2];
                else
                    result[i] = result[i / 2] + 1;
            }
            return result;
        }
