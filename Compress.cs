// https://leetcode.com/problems/string-compression/description/?envType=study-plan-v2&envId=leetcode-75

        int Compress(char[] chars)
        {
            int index = 0;
            int compressedIndex = 0;

            while(index < chars.Length)
            {
                int count = 0;
                char currentChar = chars[index];
                while(index < chars.Length && currentChar == chars[index])
                {
                    index++;
                    count++;
                }
                chars[compressedIndex] = currentChar;
                compressedIndex++;

                if (count > 1)
                {
                    var str = count.ToString();
                    foreach (char c in str)
                    {
                        chars[compressedIndex] = c;
                        compressedIndex++;
                    }
                }
            }
            return compressedIndex;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
