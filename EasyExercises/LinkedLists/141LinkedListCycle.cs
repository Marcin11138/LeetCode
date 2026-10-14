using System.Collections;

class LinkedListCycle
{
    //    Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    static void Main(string[] args)
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);


        //-4 points to 2, pos 1
        head.next.next = null;

        bool response = MyMethod(head);

        System.Console.WriteLine(response);

    }

    static bool MyMethod(ListNode head)
    {
    
    }
}

//84ms, 49.42MB
//First solution, two pointers again. This time we look if fast pointer hit the same node as slow pointer, which would be impossible without a cycle.
//So if the values are the same, we return true. If fast pointer hit the end without looping back, it returns false. 

// ListNode fast = head, slow = head;

//         while (fast != null && fast.next != null)
//         {
//             fast = fast.next.next;
//             slow = slow.next;

//             if (fast == slow)
//             {
//                 return true;
//             }

//         }

//         return false;

//104ms, 52MB
//Second solution using hashset. Not really faster, but the speed is similar. Its just other solution.
// hashset.Add return true if you were able to add an element to hashset and false if not. It also returns false when the node already exist in hashset. 
//  HashSet<ListNode> hashset = new();

//         while (head != null && head.next != null)
//         {
//             if (!hashset.Add(head.next))
//             {
//                 return true;
//             }
//             head = head.next;
//         }

//         return false;