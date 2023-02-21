using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 奇偶判斷
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入：");
            var list = new List<string>() { "8", "7", "9", "3", "11", "6", "2", "18" };
            var odd = new List<int>();
            var even = new List<int>();
            foreach(var item in list)
            {
                if(item != list.Last())
                {
                    Console.Write($"{item}, ");
                }
                else
                {
                    Console.Write(item);
                }
            }
            foreach(var item in list)
            {
                if (int.Parse(item) % 2 == 0)
                {
                    even.Add(int.Parse(item));
                }
                else
                {
                    odd.Add(int.Parse(item));
                }
            }
            var odd_od = odd.OrderBy((x) => x);
            var even_od = even.OrderBy((x) => x);
            Console.Write("\n奇數：");
            foreach (var item in odd_od)
            {
                if (item != odd_od.Last())
                {
                    Console.Write($"{item}, ");
                }
                else
                {
                    Console.Write(item);
                }
            }
            Console.Write("\n偶數：");
            foreach (var item in even_od)
            {
                if (item != even_od.Last())
                {
                    Console.Write($"{item}, ");
                }
                else
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
