using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriOdevi.Classes.Bases
{
    public class YuvarlakSekiller
    {       
            public double YariCap { get; set; }
            

            double pi = 3.14;

            public double AlanHesapla()
            {

                return pi * YariCap * YariCap;
            }

            public double CevreHesapla()
            {               
                return 2 * pi * YariCap;
            }       
    }
}
