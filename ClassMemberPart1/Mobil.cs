using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMemberPart1
{
    internal class Mobil
    {
        // field
        private string _warna;
        private string _jumlahpintu;
        private string _merek;
        private string _model;
        private string _tahunkeluaran;
        private string _klakson;

        // properti
        public string Warna
        {
            get
            {
                return _warna;
            }
            set 
            { 
                _warna = value;
            }
        }
        public string Jumlahpintu
        {
            get
            {
                return _jumlahpintu;
            }
            set
            {
                _jumlahpintu = value;
            }
        }

        public string Merek
        {
            get
            {
                return _merek;
            }
            set
            {
                _merek = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public string Tahunkeluaran
        {
            get
            {
                return _tahunkeluaran;
            }
            set
            {
                _tahunkeluaran = value;
            }
        }

        public string Klakson
        {
            get
            {
                return _klakson;
            }
            set
            {
                _klakson = value;
            }
        }

        // method
        public void mobil()
        {
            Console.WriteLine("Mobil Toyota berjalan dengan kecepatan 160km/jam");
            Console.WriteLine("Warna {0}", Warna);
            Console.WriteLine("Jumlah Pintu {0}", Jumlahpintu);
            Console.WriteLine("Merek {0}", Merek);
            Console.WriteLine("Model {0}", Model);
            Console.WriteLine("Tahun Keluaran {0}", Tahunkeluaran);
            Console.WriteLine("Klakson {0}", Klakson);
            Console.WriteLine("Mobil saya berwarna Merah, Merek Toyota, Model MVP, Keluaran Tahun 2022, dengan jumlah pintu sebanyak 4");
            Console.ReadLine();
        }
    }
}
