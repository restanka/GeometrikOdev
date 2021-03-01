using GeometriOdevi.Classes.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriOdevi.Classes
{
    public class DikUcgen : AciliSekiller, IHesaplama
    {
        double hipotenus;

        public double AlanHesapla()
        {
            return Taban * Yukseklik / 2;
        }

        public double CevreHesapla()
        {
            
            hipotenus = Math.Sqrt(Math.Pow(Taban, 2) + Math.Pow(Yukseklik, 2));
            return hipotenus + Taban + Yukseklik;
        }
    }
}
