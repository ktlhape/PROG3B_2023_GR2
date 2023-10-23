using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructure.BasicTree
{
    public class Tree
    {
        public TreeNode Root { get; set; }

        public Tree(TreeNode theRoot)
        {
            Root = theRoot;
        }
    }
}
