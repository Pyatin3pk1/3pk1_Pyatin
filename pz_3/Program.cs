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
            Console.WriteLine("Отрицательные значения информационных полей дерева:");
            List<int> a = tree.Otr();
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }


        }
    }
}