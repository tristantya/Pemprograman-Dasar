using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menukar_elemen_dan_membalikan_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nilai = { 55, 80, 67, 90, 45, 78 };
            int lulus = 0;                       // KKM = 70

            foreach (int n in nilai)
            {
                if (n >= 70) lulus++;
            }
            Console.WriteLine("Siswa lulus : " + lulus);
            Console.WriteLine("Siswa remidi: " + (nilai.Length - lulus));
        }
    }
}
