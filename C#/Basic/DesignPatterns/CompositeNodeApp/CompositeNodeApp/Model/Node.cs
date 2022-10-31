using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeNodeApp.Model
{
    internal class Node
    {
        private string _description;
        private List<Node> _children;

        public Node(string description)
        {
            _description = description;
            _children = new List<Node>();
        }

        public void AddChild(Node node)
        {
            _children.Add(node);
        }
       
        public void Display(int depth = 0)
        {
            Console.WriteLine(new String('-', depth) + Description);
            foreach (Node child in _children)
            {
                 child.Display(depth + 1);
            }
        }

        public string Description { get { return _description; } }

        public List<Node> Children { get { return _children; } }


    }
}
