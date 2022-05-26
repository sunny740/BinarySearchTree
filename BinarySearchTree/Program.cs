using System;
using BinarySearchTree;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ***** Welcome to Binary Search Tree ***** ");
        BinaryTree<int> tree = new BinaryTree<int>(56);
        tree.Insert(30);
        tree.Insert(70);
        tree.Insert(22);
        tree.Insert(40);
        tree.Insert(60);
        tree.Insert(95);
        tree.Insert(11);
        tree.Insert(65);
        tree.Insert(3);
        tree.Insert(16);
        tree.Insert(63);
        tree.Insert(67);
        tree.Display();
        tree.GetSize();
        bool result = tree.Search(63, tree);
        Console.WriteLine(result);

    }
}