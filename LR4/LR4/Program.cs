using System;
using System.Text;

namespace LR4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string strSymbols = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    strSymbols += $"{str[i]}";
                }
            }

            for (char c = '!'; c < '0' ; c++)
            {
                if (str.Contains(c))
                {
                    str = str.Replace($"{c}", "");
                }
            }

            for (char h = ':'; h <= '~'; h++)
            {
                if (str.Contains(h))
                {
                    str = str.Replace($"{h}", "");
                }
            }
            str = str + strSymbols;
            Console.WriteLine(str);






















            /*for(int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    strNumbers += $"{str[i]}";
                }
            }*/
/*
            for (char с = '0'; с <= '9'; с++)
            {
                if (str.Contains(с))
                {
                    str = str.Replace($"{с}", "");
                }
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                strSymbols += $"{str[i]}";
            }*/
           /* str = strNumbers + strSymbols;
            Console.WriteLine(str);*/
        }
    }
}
