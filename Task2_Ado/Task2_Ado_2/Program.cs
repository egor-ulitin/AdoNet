using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Ado_2
{
    class Program
    {
        static void Main(string[] args)
        {

            FileManager fileManager = new FileManager();
            List<Ring> rings = new List<Ring>();
            fileManager.Reader("input.txt", rings);
            foreach (var item in rings)
            {
                item.Show();
            }
            Console.ReadLine();
        }
    }
}
