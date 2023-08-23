using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            string[] NameArr = {"Porter Ross", "Camila Mccoy", "Josiah O'donnell", "Alexus Daugherty", "Aracely Knox",
                "Reginald Willis", "Dillon Acevedo", "Evelyn Larsen", "Ean Drake", "Jessie Ochoa", "Kyra Howe",
                "Ace Moyer", "Jermaine Conway", "Haylee Trevino", "Alice Lawson", "Janiah Davies", "Zaiden Leblanc"
                , "Efrain Boyd", "Litzy Wilson", "Lewis Dennis"};
            Console.WriteLine("Hãy nhập inputString: ");
            string input = Console.ReadLine();
            foreach (string name in NameArr)
            {
                if(name.Contains(input))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
    }
