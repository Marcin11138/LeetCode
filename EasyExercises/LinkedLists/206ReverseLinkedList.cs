class ReverseLinkedList
{


    //   Definition for singly-linked list.
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
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);


        ListNode response = MyMethod(head);

        while (response != null)
        {
            System.Console.WriteLine(response.val);
            response = response.next;

        }

    }

    static ListNode MyMethod(ListNode head)
    {
  
    }
}


//0ms, 42MB
//First solution. 
//  ListNode prev = null;

//         while (head != null)
//         {
//             ListNode next = head.next;
//             if(next == null)
//             {
//                 head.next = prev;
//                 return head;
//             }
//             ListNode current = head;

//             head.next = prev;

//             prev = head;
//             head = next;


//         }


//         return head;

//0ms, 42.97Mb
// Second recursive solution. 

// if (head == null || head.next == null)
//         {
//             return head;
//         }

//         ListNode newHead = ReverseList(head.next);

//         head.next.next = head;

//         head.next = null;


//         return newHead;
//     }