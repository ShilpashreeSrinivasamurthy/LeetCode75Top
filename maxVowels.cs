// https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/?envType=study-plan-v2&envId=leetcode-75

        int MaxVowels(string s, int k)
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < k; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    count++;
                }
            }
            maxCount = count;
            for (int i = k; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    count++;
                }
                if (vowels.Contains(s[i - k]))
                {
                    count--;
                }
                maxCount = Math.Max(maxCount, count);
            }
            return maxCount;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
