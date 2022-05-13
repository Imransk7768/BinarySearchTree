using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Welcome to Binary Search Tree");
        BinaryTree<int> tree = new BinaryTree<int>(56);
        tree.Insert(30);
        tree.Insert(65);
        tree.Insert(22);
        tree.Insert(45);
        tree.Insert(62);
        tree.Insert(88);
        tree.Insert(11);
        tree.Insert(60);
        tree.Insert(13);
        tree.Insert(6);
        tree.Insert(58);
        tree.Insert(71);
        tree.Display();
        tree.GetSize();
        bool result = tree.IfExists(67, tree);
        Console.WriteLine(result);
    }
}