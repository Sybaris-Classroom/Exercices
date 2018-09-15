using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Moto : VehiculeRoulant
    {
        public bool Cross { get; set; }

        public override float Consommation()
        {
            return (ConsoRef / 2) * Distance / 100;
        }
    }
}
