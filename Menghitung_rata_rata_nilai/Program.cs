using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menghitung_rata_rata_nilai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nilai = { 75, 85, 90, 80, 70 };
            int total = 0;

            for (int i = 0; i < nilai.Length; i++)
            {
                total += nilai[i];
            }

            double rata = (double)total / nilai.Length;

            Console.WriteLine("TOTAL       : " + total);
            Console.WriteLine("Rata-Rata   : " + rata);
        }
    }
}
