class RemoveDuplicatesFromSortedList
{

    //  Definition for singly-linked list.
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
        head.next = new ListNode(1);
        head.next.next = new ListNode(2);
        head.next.next.next = new ListNode(3);
        head.next.next.next.next = new ListNode(3);



        var response = MyFunction(head);

        while (response != null)
        {
            System.Console.WriteLine(response.val);
            response = response.next;
        }

    }

    static ListNode MyFunction(ListNode head)
    {
        if (head == null)
        {
            return head;
        }
        ListNode startPoint = head;
        ListNode pointer = head.next;

        while (pointer != null)
        {

            if (head.val != pointer.val)
            {
                head.next = pointer;
                head = head.next;
                pointer = pointer.next;
            }
            else
            {
                pointer = pointer.next;
                head.next = null;
            }
        }

        return startPoint;
    }
}


//0ms, 44.05MB 100%, 6.52%
//First solution, we just next check if the pointer.val have the same value as head.val if yes, we go further with pointer until we hit one with other value. 
//It works because the listed is sorted. 
//Pointer is always after head. 
//    if (head == null)
//         {
//             return head;
//         }
//         ListNode startPoint = head;
//         ListNode pointer = head.next;

//         while (pointer != null)
//         {

//             if (head.val != pointer.val)
//             {
//                 head.next = pointer;
//                 head = head.next;
//                 pointer = pointer.next;
//             }
//             else
//             {
//                 pointer = pointer.next;
//                 head.next = null;
//             }
//         }

//         return startPoint;