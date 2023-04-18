namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            BynaryTree tree= new BynaryTree(5);
           // tree.CreateBalancedTree(3);

            BynaryTree.GetTreeData(tree.Root);

            BynaryTree.total();
            


        }
    }
}