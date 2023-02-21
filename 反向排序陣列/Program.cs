using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反向排序陣列
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "12", "18", "13", "23", "32" };
            Console.Write("輸入：");
            foreach(string i in list)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
            list.Reverse();
            Console.Write("輸出：");
            foreach(string i in list)
            {
                Console.Write($"{i}, ");
            }
        }
    }
}
