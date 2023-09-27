
 string DecodeString(string s)
        {
            int num = 0;
            StringBuilder sb = new StringBuilder();
            Stack<int> intStack = new Stack<int>();
            Stack<StringBuilder> strStack = new Stack<StringBuilder>();

            foreach (char c in s.ToCharArray())
            {
                if (char.IsDigit(c))
                {
                    num = (num * 10) + (c - '0');
                }
                else if (c == '[')
                {
                    intStack.Push(num);
                    strStack.Push(sb);

                    num = 0;
                    sb = new StringBuilder();
                }
                else if (c == ']')
                {
                    int count = intStack.Pop();
                    StringBuilder sb2 = sb;

                    sb = strStack.Pop();

                    while(count-- > 0)
                    {
                        sb.Append(sb2);
                    }
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        // Time Complexity : O(n) where n is the length of the string
        // Space Complexity : O(1)
