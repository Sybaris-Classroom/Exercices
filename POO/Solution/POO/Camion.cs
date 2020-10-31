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
            return (12 + Charge / 1000) * Distance / 100;
        }
        public Camion()
            : base()
        {
            VitesseMaxi = 110;
        }
    }
}
