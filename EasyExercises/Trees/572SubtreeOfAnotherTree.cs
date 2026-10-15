class SubtreeOfAnotherTree
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
        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(4, new TreeNode(1), new TreeNode(2));
        root.right = new TreeNode(5);

        TreeNode subRoot = new TreeNode(4, new TreeNode(1), new TreeNode(2));


        System.Console.WriteLine(IsSubtree(root, targetSum));
    }

    static bool IsSubtree(TreeNode root, TreeNode subRoot, bool isSame = false)
    {
        
    }
}