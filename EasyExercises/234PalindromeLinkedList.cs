class PalindromeLinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    static void Main(string[] args)
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(0);
        head.next.next = new ListNode(0);




        System.Console.WriteLine(MyFunction(head));

    }

    static bool MyFunction(ListNode head)
    {
     
    }


}

//3ms, 61.42MB 94.13%, 70%
// static bool MyFunction(ListNode head)
//     {
//         if (head == null)
//         {
//             return false;
//         }
//         if(head.next == null)
//         {
//             return true;
//         }
        
//         ListNode nodePointer = head;
//         ListNode fasterNodePointer = head;
//         while (fasterNodePointer != null && fasterNodePointer.next != null)
//         {
//             fasterNodePointer = fasterNodePointer.next.next;
//             nodePointer = nodePointer.next;

//         }

//         ListNode prev = null;
//         while (nodePointer != null)
//         {
//             ListNode next = nodePointer.next;
//             if(next == null)
//             {
//                 nodePointer.next = prev;
//                 break;
//             }
//             nodePointer.next = prev;

//             prev = nodePointer;
//             nodePointer = next;

//         }

//         while (nodePointer != null)
//         {
//             System.Console.WriteLine(nodePointer.val + " " + head.val);
//             if (nodePointer.val != head.val)
//             {
//                 return false;
//             }
//             nodePointer = nodePointer.next;
//             head = head.next;
//         }
        
//         return true;
//     }