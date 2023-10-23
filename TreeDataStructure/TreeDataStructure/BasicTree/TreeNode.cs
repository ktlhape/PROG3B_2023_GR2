using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructure.BasicTree
{
    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode Parent { get; set; }
        public List<TreeNode> Children { get; set; }

        public TreeNode(int value)
        {
            Data = value;
            Children = new();
        }

        public override string? ToString()
        {
            return $"Data: ({Data}), Parent: ({Parent.Data})";
        }
    }
}
