using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeNodeApp.Model;


namespace CompositeNodeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Node node1 = new Node("Node1");
            Node node2 = new Node("Node2");
            Node node3 = new Node("Node3");
            Node node4 = new Node("Node4");
            Node node5 = new Node("Node5");
            node1.AddChild(node2);
            node1.AddChild(node3);
            node2.AddChild(node4);
            node2.AddChild(node5);
            //  node1.Display();
            node1.Display(depth : 1);
        }
        
    }
}
