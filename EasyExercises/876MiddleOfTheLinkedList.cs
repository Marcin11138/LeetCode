class MiddleOfTheLinkedList
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
        head.next.next.next.next = new ListNode(6);




        ListNode response = MyMethod(head);

        while (response != null)
        {
            System.Console.WriteLine(response.val);
            response = response.next;

        }

    }

    static ListNode MyMethod(ListNode head)
    {
        ListNode slow = head, fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}

//0ms, 41mb
//First solution, first we iterate through copy of the head to get length of it. Then we divide the count by 2. And we go forward by the amount in orginal head.
//I personally think the solution is a bit dirty as we need to iterate through head once to get count, so its not my favorite solution but it get jobs done..
//.. for this leetcode exercise. Note, that while using normal ListedList builded into C# we get access to .Count which takes out the need to iterate through it.
// 2nd solution is the more elegant solution with two pointers.
//  int count = 0;
//         ListNode headCopy = head;
//         while (headCopy != null)
//         {
//             count++;
//             headCopy = headCopy.next;
//         }
//         count = count / 2;
//         for (int i = 0; i < count; i++)
//         {
//             head = head.next;
//         }


//         return head;

//0ms, 41.16MB
//Two pointers solution, one slow that go to next node, and one fast that go two nodes forward. When the fast node hits the end the slow node stops at middle..
//.. so we just return slow.
// public ListNode MiddleNode(ListNode head) {
//         ListNode slow = head, fast = head;

//         while (fast != null && fast.next != null)
//         {
//             slow = slow.next;
//             fast = fast.next.next;
//         }

//         return slow;
//     }