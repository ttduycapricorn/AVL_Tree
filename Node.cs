using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Tree
{
    public class Node
    {
        public int Blance;             // Chi so can bang
        public int key;                // Gia tri cua khoa
        public Node pLeft;             // Node trai
        public Node pRight;            // Node phai
        public float x, y, Father;

        public Node(int key)
        {
            this.key = key;
            pLeft = null;
            pRight = null;
            Blance = 0;
        }

        public Node(int key, Node pLeft, Node pRight)
        {
            this.key = key;
            this.pLeft = pLeft;
            this.pRight = pRight;
            Blance = 0;
        }

        public int Level(ref Node root)
        {
            int count = -1;
            if ((root == null) || (root.pLeft == null && root.pRight == null))
                count = 0;
            else
                count++;
            return count;
        }

        public void GetPos(Node node, Form1 f)
        {
            if (node != null)
            {
                GetNodePos(node, f);
                node.GetPos(node.pLeft, f);
                node.GetPos(node.pRight, f);
            }
        }

        private void GetNodePos(Node node, Form1 f)
        {
            if (node.key > key)
            {
                node.x = x + Convert.ToInt32(Math.Abs((x - Father) / 2));//XÁC ĐỊNH X, Y CỦA NODE PHẢI                
            }
            else
            {
                node.x = x - Convert.ToInt32(Math.Abs((x - Father) / 2));//XÁC ĐỊNH X, Y CỦA NODE TRÁI
            }
            node.y = y + 80;
            node.Father = x;
        }
    }
}
