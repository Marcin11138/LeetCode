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

        System.Console.WriteLine(MergeTrees(root, root2).val);
    }

    
}

//1ms, 49.47MB 18.52%, 96.30%
//#1 attempt
// static TreeNode MergeTrees(TreeNode root1, TreeNode root2)
// {
//     if (root1 == null && root2 == null)
//     {
//         return null;
//     }
//     if (root1 != null && root2 != null)
//     {
//         root1.val = root1.val + root2.val;
//     }
//     else if (root1 == null)
//     {
//         return root2;
//     }

//     root1.left = MergeTrees(root1?.left, root2?.left);
//     root1.right = MergeTrees(root1?.right, root2?.right);

//     return root1;
// }

//0ms, 49.81MB. 100%, 93.83%
//#2 Attempt
//This attempt is upgrade of attempt #1. 
//Instead of running if both of them are null, if both of them are not null, and if one of them is null.
//We first check if root1 == null, if it is we return early that for example root.left = root2, if root2 was null too the second check would return null anyway.
//If there was an entry in root2, root1 was the last node on this side so it can be replaced by root2. If root2 is null, we return same root1 as it didnt change.
//If both arent null, we can sum the vals to the first root1. (As we use the root1 as the main merger);
//And on finish we return our merger object which was root1. 

// static TreeNode MergeTrees(TreeNode root1, TreeNode root2)
//     {
//         if (root1 == null)
//         {
//             return root2;
//         }
//         if(root2 == null)
//         {
//             return root1;
//         }

//         root1.val = root1.val + root2.val;
//         root1.left = MergeTrees(root1.left, root2.left);
//         root1.right = MergeTrees(root1.right, root2.right);

//         return root1;
//     }