using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTree
{
    public class TreeNode
    {
        public char data { get; set; }

        public TreeNode left { get; set; }
        public TreeNode right { get; set; }

        public TreeNode()
        {
            data = default;
            left = right = null;
        }


        public TreeNode(char data)
        {
            this.data = data;
            left = right = null;
        }

    }
}
