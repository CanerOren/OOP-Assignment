using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class YarismaTest
    {
        static void Main(string[] args)
        {
            Yarisma testYarismasi = new Yarisma("yarismacilar.txt", 45);

            testYarismasi.Baslat();
            testYarismasi.KonumlariYazdir();

            Console.Write("\n\nYENİDENA\n\n\n");

            testYarismasi.Baslat();
            testYarismasi.KonumlariYazdir();

            Console.ReadKey();
        }
    }
}
