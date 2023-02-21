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
 back:      Console.Write("請輸入一個0~9的正整數：");
            var n = int.Parse(Console.ReadLine());
            if(n > 9 || n < 0)
            {
                Console.WriteLine("不要亂輸入數字");
                goto back;
            }
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
