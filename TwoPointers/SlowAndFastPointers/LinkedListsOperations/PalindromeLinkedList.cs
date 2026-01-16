using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointers.SlowAndFastPointers.LinkedListsOperations
{
    internal class PalindromeLinkedList
    {
        ListNode curr;
        private bool IsPalindromeRec(ListNode head)
        {
            if (head == null)
            {
                return true;
            }

            if (IsPalindromeRec(head.next) && head.val == curr.val)
            {
                curr = curr.next;
                return true;
            }
            return false;

        }
        public bool IsPalindrome(ListNode head)
        {
            curr = head;
            return IsPalindromeRec(head);
        }
    }
}
