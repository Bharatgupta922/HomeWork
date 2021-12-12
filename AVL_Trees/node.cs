using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Trees
{
    public class TreeNode
    {
        public int data { get; set; }

        public TreeNode left { get; set; }
        public TreeNode right { get; set; }

        public TreeNode()
        {
            data = default;
            left = right = null;
        }


        public TreeNode(int data)
        {
            this.data = data;
            left = right = null;
        }
        
    }
}
