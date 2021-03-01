using GeometriOdevi.Classes.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriOdevi.Classes
{
    public class Dikdortgen : AciliSekiller, IHesaplama
    {
        public double AlanHesapla()
        {
            return Taban * Yukseklik;
        }

        public double CevreHesapla()
        {
            return 2 * (Taban + Yukseklik);
        }
    }
}
