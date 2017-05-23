using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace helper
{
    class Program
    {
        static void Main(string[] args)
        {
            realCard real = new realCard(123456789,123,"Leyla Garayeva",500);
            string a = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());
            virtualCard ba = new virtualCard(a, ,real);
            Console.ReadLine();



        }
    }
}
