using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVLTreeLib;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AVLTree tree = new AVLTree();
            tree.Insert(10);
            tree.Insert(1);
            tree.Insert(11);
            tree.Insert(303);
            tree.Insert(12);
            tree.Insert(89);
            tree.Insert(156);
            bool found = tree.Find(10);
            Console.WriteLine("Печать дерева:");
            tree.Print();
            tree.Delete(10);
            Console.WriteLine("Печать дерева после удаления 10:");
            tree.Print();

            tree += 1;
            Console.WriteLine("Дерево после операции +1");
            tree.Print();

            AVLTree tree2 = new AVLTree();
            tree2.Insert(10);
            tree2.Insert(1);
            tree2.Insert(11);
            tree2.Insert(25);
            Console.WriteLine("Второе дерево:");
            tree2.Print();
            AVLTree mergedTree = tree + tree2;
            Console.WriteLine("Печать слияние двух деревьев:");
            mergedTree.Print();

            Console.ReadKey();
        }
    }
}
