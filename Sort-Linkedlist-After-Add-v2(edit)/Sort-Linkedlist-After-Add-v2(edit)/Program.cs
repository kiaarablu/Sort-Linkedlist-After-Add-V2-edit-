using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Linkedlist_After_Add_v2_edit_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.Insert(1);
            operation.Insert(16);
            operation.Insert(16);
            operation.Insert(2);
            operation.Insert(100);
            operation.Insert(99);
            operation.Insert(-3);

            operation.Print();
            Console.ReadKey();
        }
    }
}
