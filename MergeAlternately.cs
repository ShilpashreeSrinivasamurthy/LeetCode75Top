// https://leetcode.com/problems/merge-strings-alternately/?envType=study-plan-v2&envId=leetcode-75

        string MergeStringsAlternatively(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while(i < word1.Length || i < word2.Length)
            {
                if (i < word1.Length)
                {
                    sb.Append(word1[i]);
                }
                if( i < word2.Length)
                {
                    sb.Append(word2[i]);
                }
                i++;
            }
            return sb.ToString();
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
