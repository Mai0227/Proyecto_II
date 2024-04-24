using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnóstico_Médico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node("");
            DecisionTree tree = new DecisionTree(root);
            tree.Diagnostico();
        }
    }
}
