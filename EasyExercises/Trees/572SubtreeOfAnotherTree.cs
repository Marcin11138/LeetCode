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
        TreeNode root = new TreeNode(-1,
    new TreeNode(-4,
        new TreeNode(-6,
            null,
            new TreeNode(-5)),
        new TreeNode(-2)),
    new TreeNode(8,
        new TreeNode(3,
            new TreeNode(0),
            new TreeNode(7)),
        new TreeNode(9)));

        TreeNode subRoot = new TreeNode(3,
            new TreeNode(0),
            new TreeNode(5848));
        System.Console.WriteLine(IsSubtree(root, subRoot));
    }

    
}

//#1 Attempt
//2ms, 48.21MB. 93.52%, 95.22%
//DFS Recursion solution. 
//Description and differences on attempt #2

// static bool IsSubtree(TreeNode root, TreeNode subRoot, bool found = false)
//     {
//         if (root == null)
//         {
//             return found;
//         }
//         if (root.val == subRoot.val)
//         {
//             if (SubRootDFSSearch(root, subRoot))
//             {
//                 return true;
//             }
//         }

//         found = IsSubtree(root.left, subRoot, found);
//         found = IsSubtree(root.right, subRoot, found);

//         return found;
//     }

//     static bool SubRootDFSSearch(TreeNode root, TreeNode subRoot, bool foundLeft = false, bool foundRight = false)
//     {
//         if (root == null && subRoot == null)
//         {
//             return true;
//         }
//         if (root == null || subRoot == null)
//         {
//             return false;
//         }

//         foundLeft = SubRootDFSSearch(root.left, subRoot.left, foundLeft);
//         foundRight = SubRootDFSSearch(root.right, subRoot.right, foundRight);

//         return foundLeft && foundRight && root.val == subRoot.val;
//     }



//#2 Attempt
//1ms, 47.90MB 100%, 99.32%
//Still DFS with recursion. 
//IsSubtree walks root normally. When a node's value equals subRoot's root value,
//it calls FoundSame to compare both trees in lockstep:
//  - both null -> same (true)
//  - only one null -> different (false)
//  - otherwise true only if the values match AND the left and right subtrees match.
//If any call returns true, IsSubtree returns true immediately.


//Differences from #1:
//  - Removed the unneeded bools (found, foundLeft, foundRight). Methods return true/false directly.
//  - IsSubtree exits early on a match instead of also searching the other side.
//  - FoundSame compares values first, and && short-circuits on the first mismatch.
//    In #1 the value check came last, so both subtrees were fully traversed before a
//    mismatch was noticed. This is the biggest time saver.

// static bool IsSubtree(TreeNode root, TreeNode subRoot)
//     {
//         if (root == null)
//         {
//             return false;
//         }
//         if (root.val == subRoot.val)
//         {
//             if (FoundSame(root, subRoot))
//             {
//                 return true;
//             }
//         }
        
//         if (IsSubtree(root.left, subRoot))
//         {
//             return true;
//         }
//         if(IsSubtree(root.right, subRoot))
//         {
//             return true;
//         }
//         return false;
//     }

//     static bool FoundSame(TreeNode root, TreeNode subRoot)
//     {
//         if (root == null && subRoot == null)
//         {
//             return true;
//         }
//         if (root == null || subRoot == null)
//         {
//             return false;
//         }

//         return root.val == subRoot.val && FoundSame(root.left, subRoot.left) && FoundSame(root.right, subRoot.right);
//     }
