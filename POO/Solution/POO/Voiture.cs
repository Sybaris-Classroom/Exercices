using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Voiture : VehiculeRoulant
    {
        public bool Airbag { get; set; }

        public override float Consommation()
        {
            return ConsoRef * Distance / 100;
        }
        public Voiture(): base()
        {
            Airbag = true;
        }
    }
}
