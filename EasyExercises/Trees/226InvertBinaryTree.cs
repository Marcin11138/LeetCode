class InvertBinaryTree
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
        TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));




        System.Console.WriteLine(MyFunction(root).left.val);
    }

    static TreeNode MyFunction(TreeNode root)
    {
        
    }

}

//0ms, 41.19MB 100%, 92.76%
//DFS recursive solution.
//We change right with left and left with right.
//On first root, the method calls itself with root.right and left.
//It changes right with left and vice versa on each move forward, it goes forward until it hits node that is null and then it goes backward.
//Perhaps the iterative solution would be better here, because we dont gain anything from going backwards. But recursive solution in this example is much shorter.


//  if (root == null)
//         {
//             return root;
//         }
//         TreeNode dummy = root.right;
//         root.right = root.left;
//         root.left = dummy;

//         MyFunction(root.left);

//         MyFunction(root.right);
        

//         return root;