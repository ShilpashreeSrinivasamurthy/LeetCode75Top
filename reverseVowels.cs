// https://leetcode.com/problems/reverse-vowels-of-a-string/description/?envType=study-plan-v2&envId=leetcode-75

        string ReverseVowels(string s)
        {
            int start = 0;
            int end = s.Length - 1;
            var stringArray = s.ToCharArray();
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            while (start < end)
            {
                while(start < end && !vowels.Contains(stringArray[start]))
                {
                    start++;
                }
                while (start < end && !vowels.Contains(stringArray[end]))
                {
                    end--;
                }
                var temp = stringArray[start];
                stringArray[start] = stringArray[end];
                stringArray[end] = temp;

                start++;
                end--;
            }
            return new string(stringArray);
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
