﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySearchTree;

namespace BinarySearchTree
{
    public class Tree
    {
        public Node parent;

        public Tree()
        {
            parent = null;
        }
        public void Add(Node node, int data)
        {
            Node newNode = new Node(data);

            if (parent == null)
            {
                parent = newNode;
            }
            else if (newNode.data < data)
            {
                Add(newNode.left, data);
            }
            else if (newNode.data > data)
            {
                Add(newNode.right, data);
            }

        }
        public void Search(Node node, int data)
        {
            Node newNode = new Node(data);

            if (newNode == null)
            {
                newNode = new Node(data);
            }
            else if (newNode.data < data)
            {
                Search(node.left, data);
            }
            else if (newNode.data > data)
            {
                Search(node.right, data);
            }
        }
    }
}
 

        
    

