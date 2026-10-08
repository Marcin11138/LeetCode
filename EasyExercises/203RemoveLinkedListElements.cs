class RemoveLinkedListElements
{


    // Definition for singly-linked list.
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
        head.next = new ListNode(2);
        head.next.next = new ListNode(6);
        head.next.next.next = new ListNode(3);
        head.next.next.next.next = new ListNode(4);
        head.next.next.next.next.next = new ListNode(5);
        head.next.next.next.next.next.next = new ListNode(6);





        int val = 6;

        ListNode response = MyMethod(head, val);

        while (response != null)
        {
            System.Console.WriteLine(response.val);
            response = response.next;

        }
    }

    static ListNode MyMethod(ListNode head, int val)
    {
   
    }
}


//0ms, 48.80MB. Beats 100%, 90.63%
//First solution. First we check if head is not empty. If it is we return the empty head. (Personally i dont think that there is need for checks like that in leetcode exercises.)
//Im using two pointers, and a dummy first node. The pointer is the node we want find next for, the checkingPointer is one that is going forward of first one..
//.. and checking if the val is not the number we dont want. If it is, we go with our pointer forward, while setting the pointer.next to null, so we dont need..
//.. to check if last node dont point to the value we dont want at the end.
// If it is different number, we set the pointer.next to it, we go to the pointer by pointer = pointer.next and we set our checking pointer forward.
// 
//
// public ListNode RemoveElements(ListNode head, int val) {
//          if(head is null)
//         {
//             return head;
//         }
//        ListNode dummy = new ListNode();
//         ListNode pointer = dummy;
//         ListNode checkingPointer = head;
   
//         while (pointer != null && checkingPointer != null)
//         {

//             if (checkingPointer.val != val)
//             {
//                 pointer.next = checkingPointer;
//                 pointer = pointer.next;
//                 checkingPointer = checkingPointer.next;
                
//             }
//             else
//             {
//                 checkingPointer = checkingPointer.next;
//                 pointer.next = null;

//             }
//         }


//         return dummy.next;
//     }

//0ms, 49.56MB Beats 100%, 19.79%
//Second recusive solution.

    //  if (head == null)
    //     {
    //         return head;
    //     }
    //     head.next = MyMethod(head.next, val);

    //     if (head.val == val)
    //     {
    //         return head.next;
    //     }
    //     else
    //     {
    //         return head;
    //     }

        