// https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/?envType=study-plan-v2&envId=leetcode-75

 public int PairSum(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            int maxSum = 0;
            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode prev = null;
            while (slow != null)
            {
                ListNode next = slow.next;
                slow.next = prev;
                prev = slow;
                slow = next;
            }

            while (prev != null)
            {
                maxSum = Math.Max(maxSum, prev.val + head.val);
                prev = prev.next;
                head = head.next;
            }
            return maxSum;
        }
