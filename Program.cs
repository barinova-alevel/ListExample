using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            LinkedList lli = new LinkedList();
            
            Node node = null;
             
            node = new Node();
            node.Value = r.Next();
            lli.Add(node);
             
            node = new Node();
            node.Value = r.Next();
            lli.Add(node);

            node = new Node();
            node.Value = r.Next();
            lli.Add(node);

            int value = r.Next();
            node = new Node();
            node.Value = value;
            lli.Add(node);

            Console.WriteLine("Output values of linked list:");
            lli.OutputAllNodes();

            lli.Remove(value);
            Console.WriteLine("Output the values of linked list after last node was removed:");
            lli.OutputAllNodes();
            Console.ReadKey();
        }
    }
}
