// https://leetcode.com/problems/find-the-difference-of-two-arrays/?envType=study-plan-v2&envId=leetcode-75

        List<List<int>> FindDifference(int[] nums1, int[] nums2)
        {
            HashSet<int> hashSet1 = new HashSet<int>();
            HashSet<int> hashSet2 = new HashSet<int>();
            List<int> result1 = new List<int>();
            List<int> result2 = new List<int>();

            foreach (int num in nums1)
            {
                hashSet1.Add(num);
            }
            foreach (int num in nums2)
            {
                hashSet2.Add(num);
            }

            foreach(int num in hashSet1)
            {
                if (!hashSet2.Contains(num))
                {
                    result1.Add(num);
                }
            }

            foreach(int num in hashSet2)
            {
                if (!hashSet1.Contains(num))
                {
                    result2.Add(num);
                }
            }
            var result = new List<List<int>>();
            result.Add(result1);
            result.Add(result2);
            return result;
        }
