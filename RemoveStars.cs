// https://leetcode.com/problems/removing-stars-from-a-string/?envType=study-plan-v2&envId=leetcode-75

        string RemoveStars(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(char c in s)
            {
                if(c == '*')
                {
                    stringBuilder.Remove(stringBuilder.Length - 1, 1);
                }
                else
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString();
        }
