// https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/?envType=study-plan-v2&envId=leetcode-75

  public ListNode DeleteMiddle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            var slow = head;
            var fast = head.next.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            slow.next = slow.next.next;
            return head;
        }
