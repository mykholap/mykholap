using System;
using System.Text;

namespace LR4_1_
{
    class Program
    {
        static string Block_1(int n)
        {
            string str = "";
            for (int i = 1; i <= n; i++)
            {
                str += $"{i} ";
            }
            return str;
        }

        static string Block_2(int n)
        {
            string str = "";
            for (int j = n; j > 0; j--)
            {
                str = $"{j} " + str;
            }
            return str;
        }

        static StringBuilder Block_3(int n)
        {
            string str = "";
            StringBuilder strb = new StringBuilder(str);
            for (int k = 1; k <= n; k++)
            {
                strb.Append($"{k} ");
            }
            return strb;
        }
        static StringBuilder Block_4(int n)
        {
            string str = "";
            StringBuilder strb = new StringBuilder(str);
            for (int t = n; t > 0; t--)
            {
                strb = strb.Insert(0, $"{t} ");
            }
            return strb;

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine(Block_1(n));
                    break;
                case 2:
                    Console.WriteLine(Block_2(n));
                    break;
                case 3:
                    Console.WriteLine(Block_3(n));
                    break;
                case 4:
                    Console.WriteLine(Block_4(n));
                    break;
            }
    }   }
}
