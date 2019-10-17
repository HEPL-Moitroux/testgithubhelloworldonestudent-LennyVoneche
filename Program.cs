using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Affichage("Hello");
                Affichage("Word !");
                Affichage("Lenny");
                Affichage("Vonèche");
                Affichage(":)");
                Affichage("<3");
            }
        }

        static void Affichage(String st)
        {
            System.Console.WriteLine(st);
            Thread.Sleep(500);
            System.Console.Clear();
        }
    }
}
