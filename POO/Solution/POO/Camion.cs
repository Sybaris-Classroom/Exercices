using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Camion : VehiculeRoulant
    {
        public bool TIR { get; set; }

        public override float Consommation()
        {
            return (ConsoRef * 2) * Distance / 100;
        }
        public Camion()
            : base()
        {
            VitesseMaxi = 110;
            VitesseMini = 90;
        }
    }
}
