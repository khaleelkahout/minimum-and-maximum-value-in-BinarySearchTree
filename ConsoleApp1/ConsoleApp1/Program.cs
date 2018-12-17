using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class BinarySearchTree
    {

        //create Node
        class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int value)
            {
                data = value;
                left = null;
                right = null;

            }

        }

        //the root of  bst 
        Node root;

        BinarySearchTree()
        {
            root = null; //root of the node will be Empty 
        }


        //** This method calls insertRec() 
        void insert(int key)
        {
            root = insertRec(root, key);
        }

        /* A recursive function to insert a new key in BST */
        Node insertRec(Node root, int key)
        {

            /* If the tree is empty, return a new node */
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            /* Otherwise, recur down the tree */
            if (key < root.data)
                root.left = insertRec(root.left, key);
            else if (key > root.data)
                root.right = insertRec(root.right, key);

            /* return the (unchanged) node pointer */
            return root;
        }

        /* Given a binary tree, print  
           its nodes in Postorder*/
        void printPostorder(Node node)            //left,right,root
        {
            if (node == null)
                return;

            // first recur on left subtree 
            printPostorder(node.left);

            // then recur on right subtree 
            printPostorder(node.right);

            // now deal with the node 
            Console.Write(node.data + " ");
        }

        /* Given a binary tree, print  
           its nodes in inorder*/

        void printInorder(Node node)            //left,root,right
        {
            if (node == null)
                return;
            
            /* first recur on left child */
            printInorder(node.left);
            /* then print the data of node */
            Console.Write(node.data + " ");
            /* now recur on right child */
            printInorder(node.right);
        }

        



        /* Given a binary tree, print 
           its nodes in preorder*/

        void printPreorder(Node node)            //root,lrft,right
        {
            if (node == null)
                return;

            /* first print data of node */
            Console.Write(node.data + " ");

            /* then recur on left sutree */
            printPreorder(node.left);

            /* now recur on right subtree */
            printPreorder(node.right);
        }

        // Wrappers over above recursive functions 

        // This method mainly calls Postorder() 
        void printPostorder()
        {
            printPostorder(root);
        }
        // This method mainly calls InorderRec() 
        void printInorder()
        {
            printInorder(root);
        }
        // This method mainly calls Preorder() 
        void printPreorder()
        {
            printPreorder(root);
        }


        int FindMin(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Error !>>>>The tree is Empty");
                return -1;
            }
            while (root.left != null)
            {
                root = root.left;
            }


            return root.data;

        }

        int FindMax(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Error !>>>>The tree is Empty");
                return -1;
            }
            while (root.right != null)
            {
                root = root.right;
            }


            return root.data;

        }

        int Max()
        {

            return FindMax(root);
        }

        int Min()
        {

            return FindMin(root);
        }

        static void Main(string[] args)
        {

            BinarySearchTree tree = new BinarySearchTree();
            Random rnd = new Random();

            int[] item = new int[10000];

            for (int i = 0; i < 10000; i++)
            {
                tree.insert(item[i] = rnd.Next(0,9));
            }



            Console.WriteLine("Preorder traversal " +
                               "of Binary Search Tree is ");
            tree.printPreorder();

            Console.WriteLine("\nInorder traversal " +
                                        "of Binary Search Tree is ");
            tree.printInorder();

            Console.WriteLine("\nPostorder traversal " +
                                  "of Binary Search Tree is ");
            tree.printPostorder();

            Console.WriteLine("\n");

            int minimum = tree.Min();
            int maksimum = tree.Max();

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine();
            Console.WriteLine("minimum degeri = " + minimum);
            Console.WriteLine("maksimum degeri = " + maksimum);

            Console.WriteLine("                                                                                                   Ali Almanea </>   ");
            Console.ReadLine();

        }

    }
}



