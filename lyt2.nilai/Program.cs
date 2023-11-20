using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Latihan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nama : ");
            string nama = Console.ReadLine();
            Console.Write("Nilai Harian :");
            int nilHarian = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai UTS :");
            int nilUts = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai UAS :");
            int nilUas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===================================");
            int rataRata = (nilHarian + nilUts + nilUas) / 3;
            Console.WriteLine("Nama : " + nama);
            Console.WriteLine("NilHar : " + nilHarian);
            Console.WriteLine("NilUts : " + nilUts);
            Console.WriteLine("NilUas : " + nilUas);
            Console.WriteLine("rataRata : " + rataRata.ToString());

            if (rataRata >= 80)
            {
                Console.WriteLine("Predikat : A");
            }
            else if (rataRata >= 70)
            {
                Console.WriteLine("Predikat : B");
            }
            else if (rataRata >= 60)
            {
                Console.WriteLine("Predikat : C");
            }
            else if (rataRata >= 50)
            {
                Console.WriteLine("Predikat : D");
            }
            else
            {
                Console.WriteLine("Predikat : E");
            }

            Console.ReadKey();

        }
    }
}

