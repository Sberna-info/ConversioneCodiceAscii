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
            Console.Write("inserisci la lettere che vuoi convertire: ");
            char carattere = Convert.ToChar(Console.ReadLine());
            ushort carattereascii = 0;
            carattereascii = carattere;
            Console.WriteLine($"la lettera - {carattere}, Carattere in ascii - {carattereascii}");
            Console.ReadLine();

        }
    }
}
