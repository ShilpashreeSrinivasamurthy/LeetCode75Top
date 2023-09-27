// https://leetcode.com/problems/unique-number-of-occurrences/?envType=study-plan-v2&envId=leetcode-75

        bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }

            HashSet<int> hashSet = new HashSet<int>();
            foreach(var value in dict)
            {
                hashSet.Add(value.Value);
            }
            return hashSet.Count == dict.Count;
        }
