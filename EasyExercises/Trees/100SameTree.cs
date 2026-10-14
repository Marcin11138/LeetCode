using System.Text.Json;

class SameTree
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    static void Main(string[] args)
    {
        TreeNode p = new TreeNode(1, null, new TreeNode(1, new TreeNode(2)));
        TreeNode q = new TreeNode(1, null, new TreeNode(1, null, new TreeNode(2)));



        System.Console.WriteLine(MyFunction(p, q));
    }

    static bool MyFunction(TreeNode p, TreeNode q)
    {
        
        
    }




}



//0ms, 42.40MB 100%, 99.90%
//BFS iterative solution. 
//Using queues.count > 0 (if there is more than 0 entries in queue, loop).
//Before loop we check if both of the trees are empty if so, we return true. As they are same.
//Then we check if one of them is null if so they cant be same. So we return false.
//On start of each loop we check if we have the same amount of nodes if we dont we return false.
//We also check if one of the current nodes we use is empty if  it is, we return false.
//And finally we check if the nodes we are at are the same, if not we return false.
//If any of these checks didnt return false we return true at the end.


//          Queue<TreeNode> pQueue = new();
//         Queue<TreeNode> qQueue = new();


//       
//         if (p == null && q == null)
//         {
//             return true;
//         }
//         if(p == null || q == null)
//         {
//             return false;
//         }
//         pQueue.Enqueue(p);
//         qQueue.Enqueue(q);

//         while (pQueue.Count > 0 && qQueue.Count > 0)
//         {
//             TreeNode pNode = pQueue.Dequeue();
//             TreeNode qNode = qQueue.Dequeue();

//             if (pQueue.Count != qQueue.Count)
//             {
//                 return false;
//             }
//              if( pNode == null || qNode == null)
//             {
//                return false;
//             }
//             if (pNode.val != qNode.val)
//             {
//                 return false;
//             }

//             if (pNode.left != null || qNode.left != null)
//             {
//                 pQueue.Enqueue(pNode.left);
//                 qQueue.Enqueue(qNode.left);
//             }
//             if (pNode.right != null || qNode.right != null)
//             {
//                 pQueue.Enqueue(pNode.right);
//                 qQueue.Enqueue(qNode.right);
//             }

//         }
//         return true;
