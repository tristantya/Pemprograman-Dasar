using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_dan_program_bawaan_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] angka = { 47, 1, 89, 5, 25, 67, 54, 9 };

            Array.Sort(angka);
            Console.WriteLine("Berurutan : " + string.Join(",", angka));

            Array.Reverse(angka);
            Console.WriteLine("Berbalik  : " + string.Join(",", angka));

            Console.WriteLine("Indeks 54 : " + Array.IndexOf(angka, 54));
            Console.WriteLine("Jumlah    : " + angka.Sum());
            Console.WriteLine("Terbesar  : " + angka.Max());
        }
    }
}
