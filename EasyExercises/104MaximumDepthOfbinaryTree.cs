class MaximumDepthOfbinaryTree
{


    //  Definition for a binary tree node.
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

        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20, new TreeNode(15), new TreeNode(7));
        System.Console.WriteLine(MyFunction(root));

    }

    static int MyFunction(TreeNode node)
    {

      
    }
}


//1ms, 45.48MB 15.87%, 90.39%
//BFS iteration solution
//We swap references to the List after foreach loop. And clean the old parent (current nextQueue);
//    List<TreeNode> parentQueue = new();
//         List<TreeNode> nextQueue = new();
//         int depth = 0;
//         if(root != null)
//         {
//             parentQueue.Add(root);

//         }

//         while (parentQueue.Count > 0)
//         {

//             if (parentQueue.Count > 0)
//             {
//                 depth++;
//             }
            
//             foreach (TreeNode node in parentQueue)
//             {

//                 if (node.left != null)
//                 {
//                     nextQueue.Add(node.left);
//                 }
//                 if (node.right != null)
//                 {
//                     nextQueue.Add(node.right);
//                 }
//             }

//             List<TreeNode> temp = parentQueue;
//             parentQueue = nextQueue;
//             nextQueue = temp;

//             nextQueue.Clear();
            
//         }


//         return depth;

//1ms, 45.27MB 15.87%, 97.01%
//2nd Version still BFS still iterative, i found out that there is quque method in C# that i used in this attempt instead of 2 Lists. We save mostly on memory.
// Queue<TreeNode> queue = new();

//         int depth = 0;
//         if (root != null)
//         {
//             queue.Enqueue(root);

//         }

//         while (queue.Count > 0)
//         {
            
//             int levelSize = queue.Count;
//             depth++;
            
//             for (int i = 0; i < levelSize; i++)
//             {
//                 TreeNode node = queue.Dequeue();

//                 if (node.left != null)
//                 {
//                     queue.Enqueue(node.left);
//                 }
//                 if (node.right != null)
//                 {
//                     queue.Enqueue(node.right);
//                 }
//             }
           
//         }


//         return depth;


//0ms, 45.78% 100%, 66.62%
//Third solution this time using DFS with recursion. 
//On last iteration when we hit null we set our int left or right to 0, and we count how many steps upwards in recursion it goes; 
//  if (node == null)
        // {
        //     return 0;
        // }

        // int left = MyFunction(node.left);

        // int right = MyFunction(node.right);


        // if (left > right)
        // {
        //     return left + 1;
        // }
        // else
        // {
        //     return right + 1;
        // }