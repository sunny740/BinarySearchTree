using System;
using BinarySearchTree;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ***** Welcome to Binary Search Tree ***** ");
        BinaryTreeCreate<int> tree = new BinaryTreeCreate<int>(56);
        tree.Insert(30);
        tree.Insert(70);
        tree.Display();
    }
}