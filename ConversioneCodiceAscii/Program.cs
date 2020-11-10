using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversioneCodiceAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort decimale = 0;
            Console.Write("inserisci una lettera:");
            char carattere = Convert.ToChar(Console.ReadLine());
            decimale = carattere;
            Console.WriteLine($"La lettera - {carattere} convertito in ASCII è - {decimale}");
            string esadecimale = decimale.ToString("X");
            Console.WriteLine($"Il numero decimale convertito in esadecimale è :{esadecimale}");
            Console.ReadLine();

        }
    }
}
