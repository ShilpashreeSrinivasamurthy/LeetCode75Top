//https://leetcode.com/problems/odd-even-linked-list/?envType=study-plan-v2&envId=leetcode-75

  public ListNode OddEvenList(ListNode head)
        {
            ListNode oddNode = head;
            ListNode evenNode = head.next;
            ListNode evenHead = evenNode;
            while (evenNode != null && evenNode.next != null)
            {
                oddNode.next = oddNode.next.next;
                evenNode.next = evenNode.next.next;

                oddNode = oddNode.next;
                evenNode = evenNode.next;
            }
            oddNode.next = evenHead;
            return head;
        }
