// https://leetcode.com/problems/is-subsequence/?envType=study-plan-v2&envId=leetcode-75

       bool IsSubSequence(string s, string t)
        {
            int i = 0;
            int j = 0;
            while(i < s.Length && j < t.Length)
            {
                if(s[i] == t[j])
                {
                    i++;
                }
                j++;
            }
            return i == s.Length;
        }
        // Time Complexity : O(n) where n is the length of t
        // Space Complexity : O(1)
