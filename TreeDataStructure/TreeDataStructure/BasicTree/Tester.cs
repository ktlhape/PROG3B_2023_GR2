using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructure.BasicTree
{
    /*          100
     *          
     *      50    1     150   
     *      
     *          70   61
     */
    internal class Tester
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(100);
            Tree myTree = new Tree(root);

            TreeNode childOne = new(50);
            TreeNode childTwo = new(1);
            TreeNode childThree = new(150);

            TreeNode child70 = new(70);
            child70.Parent = childTwo;
            TreeNode child61 = new(61);
            child61.Parent = childTwo;

            TreeNode child12 = new TreeNode(12);
            child12.Parent = childOne;

            childOne.Parent = root;
            childTwo.Parent = root;
            childThree.Parent = root;

            root.Children.Add(childOne);
            childOne.Children.Add(child12);
            root.Children.Add(childTwo);
            //Add children
            childTwo.Children.Add(child70);
            childTwo.Children.Add(child61);
            root.Children.Add(childThree);

            foreach (TreeNode parent in root.Children)
            {
                Console.WriteLine(parent);
                foreach (TreeNode child in parent.Children)
                {
                    Console.WriteLine($"\t{child}");
                }
            }

            Console.Read();

        }
    }

}
