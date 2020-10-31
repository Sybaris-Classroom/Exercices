using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Voiture : VehiculeRoulant
    {
        public bool Airbag { get; set; } = true;

        public override float Consommation()
        {
            return (5 + 0.1f * Passagers) * Distance / 100;
        }
    }
}
