class MergeTwoBinaryTrees
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
        TreeNode root = new TreeNode(1, new TreeNode(3, new TreeNode(5)), new TreeNode(2));
        TreeNode root2 = new TreeNode(2, new TreeNode(1, null, new TreeNode(4)), new TreeNode(3, null, new TreeNode(7)));

        System.Console.WriteLine(MyFunction(root, root2).val);
    }

    static TreeNode MyFunction(TreeNode? root1, TreeNode? root2)
    {
       

        return root1;
    }
}