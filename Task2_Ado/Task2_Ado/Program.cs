using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Ado
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager fileManager = new FileManager();
            List<User> persons = new List<User>();
            fileManager.Reader("input.txt", persons);
            foreach(var item in persons)
            {
                item.Show();
            }
            Console.ReadLine();
        }
    }
}
