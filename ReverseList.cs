// https://leetcode.com/problems/reverse-linked-list/?envType=study-plan-v2&envId=leetcode-75

        public ListNode ReverseList(ListNode head)
        {
            ListNode newHead = null;
            while(head != null)
            {
                ListNode next = head.next;
                head.next = newHead;
                newHead = head;
                head = next;
            }
            return newHead;
        }
