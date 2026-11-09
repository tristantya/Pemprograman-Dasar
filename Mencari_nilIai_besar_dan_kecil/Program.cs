using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mencari_nilIai_besar_dan_kecil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 64, 88, 72, 95, 81 };

            int max = data[0];     // anggap elemen pertama sebagai yang terbesar
            int min = data[0];     // dan juga yang terkecil

            for (int i = 1; i < data.Length; i++)
            { 
                if (data[i] > max) max = data[i];
                if (data[i] < min) min = data[i]; 
            }
            Console.WriteLine("Nilai tertinggi : " + max);
            Console.WriteLine("Nilai terendah  : " + min);
        }
    }
}
