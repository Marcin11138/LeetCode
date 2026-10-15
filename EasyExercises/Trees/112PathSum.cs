class PathSum
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
        TreeNode root = new TreeNode(5);
        root.left = new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2)));
        root.right = new TreeNode(8, new TreeNode(13), new TreeNode(4, null, new TreeNode(1)));


        int targetSum = 22;



        System.Console.WriteLine(HasPathSum(root, targetSum));
    }




}



//0ms, 45.29MB 100%, 100%
//DFS Recursive solution.
//First we check if root is null if it is we return false.
//Because we cant change how caller is calling the method on LeetCode, i added int sum as nullable so we can distinguish initial call from recusive calls. So on first iteration if sum is null it set it to root.val;
//On very iteration now we add current branch.val if through iteration the sum == targetSum, going upwards now it will return true on every call. If it wasnt true, our iteration and recursion finishes and we return false.
//What could be done here better is that we could separate it into two separate methods, as for example root == null dont need to be checked on every iteration. 

//  static bool HasPathSum(TreeNode root, int targetSum, int? sum = null) {
//         if (root == null)
//         {
//             return false;
//         }

//         if (sum == null)
//         {
//             sum = root.val;
//         }
//         if (sum == targetSum && root.left == null && root.right == null)
//         {
//             return true;
//         }

//         if (root.left != null)
//         {
//             if (HasPathSum(root.left, targetSum, sum + root.left.val))
//             {
//                 return true;
//             }
//         }
//         if (root.right != null)
//         {
//             if (HasPathSum(root.right, targetSum, sum + root.right.val))
//             {
//                 return true;
//             }

//         }

//         return false;
//     }