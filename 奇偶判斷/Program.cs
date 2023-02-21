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
            var odd = new List<string>();
            var even = new List<string>();
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
                    even.Add(item);
                }
                else
                {
                    odd.Add(item);
                }
            }
            Console.Write("奇數：");
            foreach (var item in odd)
            {
                if (item != odd.Last())
                {
                    Console.Write($"{item}, ");
                }
                else
                {
                    Console.Write(item);
                }
            }
            foreach (var item in even)
            {
                if (item != even.Last())
                {
                    Console.Write($"{item}, ");
                }
                else
                {
                    Console.Write(item);
                }
            }
        }
    }
}
