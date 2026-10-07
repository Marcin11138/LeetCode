using System.Text.Json;
using System.Text.Json.Serialization;

class MergeTwoSortedLists
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
        ListNode list1 = new ListNode(1);
        list1.next = new ListNode(2);
        list1.next.next = new ListNode(4);

        ListNode list2 = new ListNode(1);
        list2.next = new ListNode(3);
        list2.next.next = new ListNode(4);

        ListNode response = MyFunction(list1, list2);
        while (response != null)
        {
            System.Console.WriteLine(response.val);
            response = response.next;
        }

    }

    static ListNode MyFunction(ListNode list1, ListNode list2)
    {

    }
}

//0ms, 43.66MB
//This one was a struggle, understanding how nodes are saved in memory was a tricky thing to take in. 
//Fought a bit to solve it by myself, but had to access other people solutions and a bit of googling to understand whats going on.
//In short. We create first dummy node, this node access directly the same node that is referenced in dummy in memory. 
//In middle of first iteration we set the pointer in the memory to point to node from list. 
//This is for us to remember start of the linked list.
// On end of first iteration our node goes into one of the nodes that are already in List(1 or 2), we go to next node in list everytime we set it as next in node.
// As last we  also check if there are any reminders in lists, if so we add it as next pointer in our node.

        //ListNode dummy = new ListNode();
        // ListNode node = dummy;

        // while (list1 != null && list2 != null)
        // {
        //     if (list1.val <= list2.val)
        //     {
        //         node.next = list1;
        //         list1 = list1.next;
        //     }
        //     else
        //     {
        //         node.next = list2;
        //         list2 = list2.next;
        //     }
        //     node = node.next;
        // }

        // if (list1 != null)
        // {
        //     node.next = list1;
        // }
        // if(list2 != null)
        // {
        //     node.next = list2;
        // }

       
        // return dummy.next;