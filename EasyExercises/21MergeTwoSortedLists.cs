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
        ListNode list1 = null;


        ListNode list2 = null;


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
//In short. We create first dummy node, this is a dummy node, because we are going to use it only as head pointing to next node.
//Node variable is pointer, it points current node we are in. So on first loop the "node" is dummy node reference. Where we set the node.next with one that should be  next..
//.. in this example node with smaller number which will be first node in list1 or 2. On next iteration our pointer is on the first node in one of the list (node = listx)
//And the listx pointer moved forward, as the first entry is already used. (So it look at next node in the same list instead on itself); 
//It iterates after until list1 or list2 isnt null. 
//As last we  also check if there are any reminders in lists, if so we add it as next pointer in our node.
//We return dummy.next as next node is the true head we want without dummy node.

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