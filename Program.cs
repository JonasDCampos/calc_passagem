using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora";
            Console.WriteLine("--- Passagem ---");

            double transurc = 0, bus = 0, dias_trab;
            string tmp;

            Console.ReadKey();

            //Dias trabalhados
            Console.WriteLine("Digite os dias trabalhados no mês: ");
            tmp = Console.ReadLine();
            dias_trab = double.Parse(tmp);

            //Calculo
            transurc = (5.15 * 2) * dias_trab;
            bus = (5.25 * 2) * dias_trab;

            Console.WriteLine("\n\nTransurc: R$" + transurc + "\nBus: R$" + bus);

            Console.ReadKey();
        }

    }
}