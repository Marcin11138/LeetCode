class MinimumDepthOfbinaryTree
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

//1ms, 86.37. 98.63%, 8.79%.
//BFS solution is here better as we need to find the closest leaf(node with null right and left);
// Queue<TreeNode> queue = new();
//         int count = 0;
//         if (node != null)
//         {
//             queue.Enqueue(node);

//         }
        
//         while (queue.Count > 0)
//         {
//             count++;
//             for (int i = queue.Count; i > 0; i--)
//             {
//                 TreeNode currentNode = queue.Dequeue();
//                 if (currentNode.left == null && currentNode.right == null)
//                 {
//                     return count;
//                 }

//                 if (currentNode.left != null)
//                 {
//                     queue.Enqueue(currentNode.left);
//                 }
//                 if (currentNode.right != null)
//                 {
//                     queue.Enqueue(currentNode.right);
//                 }
//             }
            

//         }

//         return count;