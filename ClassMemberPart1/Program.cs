using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMemberPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil();
            Mobil mobil2 = new Mobil();
            Mobil mobil3 = new Mobil();

            mobil1.Warna = "Merah";
            mobil1.Jumlahpintu = "4";
            mobil1.Merek = "Toyota";
            mobil1.Model = "MVP";
            mobil1.Tahunkeluaran = "2022";
            mobil1.Klakson = "Tin... Tin... Tin...";
            mobil1.mobil();
            Console.ReadLine();
        }
    }
}


