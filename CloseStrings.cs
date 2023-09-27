https://leetcode.com/problems/determine-if-two-strings-are-close/?envType=study-plan-v2&envId=leetcode-75

bool CloseStrings(string word1, string word2)
        {
            var word1Array = new char[26];
            var word2Array = new char[26];

            foreach(char c in word1)
            {
                word1Array[c - 'a']++;
            }

            foreach (char c in word2)
            {
                word2Array[c - 'a']++;
            }
            for(int i = 0; i < 26; i++)
            {
                if(word1Array[i] == word2Array[i])
                {
                    continue;
                }
                if (word1Array[i] == 0 || word2Array[i] == 0)
                {
                    return false;
                }
            }
            Array.Sort(word1Array);
            Array.Sort(word2Array);
            for (int i = 0; i < 26; i++)
            {
                if (word1Array[i] != word2Array[i])
                {
                    return false;
                }
            }
                return true;
        }
