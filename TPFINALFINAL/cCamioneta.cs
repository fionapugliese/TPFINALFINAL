using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINALFINAL
{
    internal class cCamioneta : cVehiculo
    {


        public cCamioneta(int nafta_, int meses, float precio) : base(meses, nafta_, precio)
        {
            peso = 3500;
            volumen = 1441;//5000000

        }
        ~cCamioneta() { }
    }
}
