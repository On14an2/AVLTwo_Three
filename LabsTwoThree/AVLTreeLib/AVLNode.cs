using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTreeLib
{
    public class AVLNode
    {
        public double Key { get; set; }
        public AVLNode Left { get; set; }
        public AVLNode Right { get; set; }
        public int Height { get; set; }

        public AVLNode(double key)
        {
            Key = key;
            Left = null;
            Right = null;
            Height = 1;
        }
    }
}
