class AverageOfLevelsInBinaryTree
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
        TreeNode root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));


        System.Console.WriteLine(MyFunction(root)[1]);
    }


    static IList<double> MyFunction(TreeNode root)
    {
        
    }

}

//#1 Attempt
//4ms, 49.59MB 19.12%, 100%;
// static IList<double> MyFunction(TreeNode root)
//     {
//         List<double> averages = new();
//         Queue<TreeNode> parentQueue = new();
//         Queue<(TreeNode left, TreeNode right)> childrenQueue = new();
//         if (root != null)
//         {
//             parentQueue.Enqueue(root);
//         }

//         double parentSum = 0;
        
//         while (parentQueue.Count > 0)
//         {
           
//             int parentCount = parentQueue.Count;
//             while (parentQueue.Count > 0)
//             {
//                 var parent = parentQueue.Dequeue();
//                 parentSum = parentSum + parent.val;

//                 if (parentQueue.Count == 0)
//                 {
//                     averages.Add(parentSum / parentCount);
//                     parentSum = 0;
//                 }

//                 childrenQueue.Enqueue((parent.left, parent.right));
//             }

//             while (childrenQueue.Count > 0)
//             {
//                 var (left, right) = childrenQueue.Dequeue();
//                 if (left != null)
//                 {
//                 parentQueue.Enqueue(left);

//                 }
//                 if (right != null)
//                 {
//                 parentQueue.Enqueue(right);
                    
//                 }
//             }
//         }


//         return averages;
//     }


//2# attempt 
//2ms, 49.68MB  97.86%, 100%
//Iterative BFS
//Much better solution running only with one queue as it should, from the start. 
//We run a while loop, while the queue.Count > 0 and we get how many nodes are currently in the queue as it is the levelCount, we start from root so it is 1.
//We have a sum outside of our next loop which is for loop, because its a for loop and not while loop it stops after the levelCount set above is 0. 
//In the for loop, we dequeue a node, and add it to sum. We add the children nodes to the queue. When the for loop ends we add a entry to averagesList we created.
//which is sum / amountOfNodes
//And because there are still nodes in queue the while loop again, and we start with next level. It stops when there is no nodes in queue, which will be at last level.
//  static IList<double> MyFunction(TreeNode root)
//     {
//         List<double> averages = new();
//         Queue<TreeNode> queue = new();
//         if(root == null)
//         {
//             return [];
//         }

//         queue.Enqueue(root);
//         while(queue.Count > 0)
//         {
//             int levelCount = queue.Count;
//             double sum = 0;

//             for (int i = 0; i < levelCount; i++)
//             {
//                 TreeNode node = queue.Dequeue();

//                 sum = sum + node.val;

//                 if (node.left != null)
//                 {
//                     queue.Enqueue(node.left);
//                 }
//                 if (node.right != null)
//                 {
//                     queue.Enqueue(node.right);
//                 }
//             }
//             averages.Add(sum / levelCount);
//         }
         

//         return averages;
//     }