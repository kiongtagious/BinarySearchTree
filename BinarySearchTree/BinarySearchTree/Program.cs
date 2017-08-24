using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySearchTree;

namespace BinarySearchTree { }
    public class Program
{
    static void Main(string[] args)
    {
        Tree newTree = new Tree();

        newTree.Search(10);
        newTree.display();

        Console.ReadLine();

    }
}

