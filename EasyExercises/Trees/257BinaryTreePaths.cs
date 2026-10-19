class BinaryTreePaths
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
        TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(5), new TreeNode(6)), new TreeNode(3));


        System.Console.WriteLine(MyFunction(root)[1]);
    }


}

//0ms, 47.36MB 100%, 100%
//We run DFS with recursion.
//We start with dummy = null, so we set it at the start of loop with if dummy == null
//Then it goes to left node, and adds the current value of left node to the same string.
//If we hit a node that dont point anymore, we add our string to our main path list. 
//Then it goes back upwards once, and if we have a right node left, it does the same. 
//And it repeats upwards. 


// static IList<string> MyFunction(TreeNode root)
//     {

//         IList<string> list = new List<string>();
//         list =  DFS(root, list);
//         return list;
        


//     }

//     static IList<string> DFS(TreeNode pointer, IList<string> path, string dummy = null)
//     {
//         if (dummy == null)
//         {
//             dummy = "" + pointer.val;
//         }
//         else
//         {
//             dummy = dummy + "->" + pointer.val;
//         }

//         if (pointer.left != null)
//         {
//             path = DFS(pointer.left, path, dummy);


//         }
//         if (pointer.right != null)
//         {

//             path = DFS(pointer.right, path, dummy);

//         }

//         if (pointer.left == null && pointer.right == null)
//         {
//             path.Add(dummy);
//             return path;
//         }

//         return path;
//     }