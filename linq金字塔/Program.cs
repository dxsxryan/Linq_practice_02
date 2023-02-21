using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq金字塔
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個正整數：");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            var seq = Enumerable.Range(1, n);
            var pyramid = seq.Select(i => new string(Convert.ToChar(n - i + 49), i));

            foreach (var line in pyramid)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();

        }
    }
}
