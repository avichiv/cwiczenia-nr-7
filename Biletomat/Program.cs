using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biletomat
{
    class Program
    {
        static void Main(string[] args)
        {
            string bilet, rodzajBiletu;
            Console.Write("Dzień dobry! \nOkreśl rodzaj biletu\nA - autobusowe\nK - kolejowe\nZ - zakończ działanie programu\n");
            do
            {
                bilet = Console.ReadLine();
                if (bilet == "A")
                {
                    Console.WriteLine("Podaj rodzaj biletu: (N - normalny, U - ulgowy)\n");
                    rodzajBiletu = Console.ReadLine();
                }
                else if (bilet == "K")
                {
                    Console.WriteLine("Podaj rodzaj biletu: (N - normalny, U - ulgowy)\n");
                    rodzajBiletu = Console.ReadLine();
                }
                else if (bilet == "Z")
                {
                    Console.WriteLine("Zapraszamy ponownie\n");
                }
                else
                {
                    Console.WriteLine("Podałeś złą wartość\nSpróbuj jeszcze raz:\n");
                }
                Console.WriteLine("Co chcesz dalej robić?\nOkreśl rodzaj biletu\nA - autobusowe\nK - kolejowe\nZ - zakończ działanie programu\n");
            } while (bilet != "Z");
            Console.ReadKey();

        }
    }
}
