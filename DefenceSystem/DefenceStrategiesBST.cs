using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DefenceSystem
{
    internal class DefenceStrategiesBST
    {
        public DefenceStrategiesNode Root { get; set; }
        public DefenceStrategiesBST()
        {
            Root = null;
        }
        public void Insert(int minSeverity, int maxSeverity, string[] defenses)
        {
            Root = InsertRecursive(Root, minSeverity, maxSeverity, defenses);

        }
        private DefenceStrategiesNode InsertRecursive(DefenceStrategiesNode root, int minSeverity, int maxSeverity, string[] defenses)
        {
            if (root == null)
            {
                root = new DefenceStrategiesNode(minSeverity, maxSeverity, defenses);
                return root;
            }
            if (minSeverity < root.MaxSeverity)
                root.Left = InsertRecursive(root.Left, minSeverity, maxSeverity, defenses);
            else 
                root.Right = InsertRecursive(root.Right, minSeverity, maxSeverity, defenses);
            return root;

        }
        public void PreOrderTraversal(DefenceStrategiesNode node)
        {
            if (node == null)
                return;

            Console.Write($"child: [{node.MinSeverity}-{node.MaxSeverity}] defenses: {node.Defenses[0]}");
            for (int i = 1; i < node.Defenses.Length; i++)
            {
                Console.Write($", {node.Defenses[i]}");
            }
            Console.WriteLine();
            if (node.Left != null)
            {
                Console.Write("|-- Left ");
                PreOrderTraversal(node.Left);
            }
            if (node.Right != null)
            {
                Console.Write("|-- Right ");
                PreOrderTraversal(node.Right);
            }



        }
        public void PrintDefenceStrategiesBST()
        {
            Console.WriteLine("Tree structure with left/right child distinctions:");
            Console.Write($"Root: [{Root.MinSeverity}-{Root.MaxSeverity}] defenses: {Root.Defenses[0]}");
            for (int i = 1; i < Root.Defenses.Length; i++)
            {
                Console.Write($", {Root.Defenses[i]}");

            }
            Console.WriteLine("");
            Console.Write("|-- Left ");
            PreOrderTraversal(Root.Left);
            Console.WriteLine();
            Console.Write("|-- Right ");
            PreOrderTraversal(Root.Right);
            Console.WriteLine();
        }
        public DefenceStrategiesNode FindDefence(DefenceStrategiesNode node, int severity)
        {
            if (node == null)
                return null;
            if (severity >= node.MinSeverity && severity <= node.MaxSeverity)
            {
                return node;
            }
            if (severity < node.MinSeverity)
            {
                return FindDefence(node.Left, severity);
            }
            return FindDefence(node.Right, severity);
            
        }

        public int FindMin()
        {
            DefenceStrategiesNode minNode = Root;
            while (minNode.Left!= null)
            {
                minNode = minNode.Left;
            }
            return minNode.MinSeverity;
        }


    }
}
