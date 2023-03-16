using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// класс бинарного дерева - имеет корневой узел - Root
    /// </summary>
    internal class BynaryTree
    {
        public Node Root { get; set; }

        public  BynaryTree(int n)
        {
            Root = CreateBalancedTree(n);
        }

        public Node CreateBalancedTree(int n)
        {
            string text;
            Node root;

            if (n == 0)
                root = null;
            else
            {
                Console.WriteLine("enter data>>");
                text = Console.ReadLine();

                root = new Node(text);
                root.Left = CreateBalancedTree(n/2);
                root.Right = CreateBalancedTree(n-n/2-1);
            }

            return root;
        }

        public static void GetTreeData(Node root)
        {
            if (root != null)
            { 
                Console.WriteLine(root.Info);
                GetTreeData(root.Left);
                GetTreeData(root.Right); 
            }
            //добавить три метода из пз3
           
        }
        public static void CountNam(Node root)
        {
            int pol = 0, otr = 0;

            for (int i = 0; i < root.Length; i++)
            {
                if (root[i] >= 0)
                    pol++;
                else
                    otr++;
            }
            Console.WriteLine($"Количество положительных чисел: {pol}\nКоличество отрицательных чисел: {otr}");
            Console.ReadLine();
        }

    }
}
