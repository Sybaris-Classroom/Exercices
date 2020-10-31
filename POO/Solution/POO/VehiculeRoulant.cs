using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    abstract class  VehiculeRoulant : VehiculeAMoteur
    {
        public int Passagers { get; set; } = 4;
        public int Charge { get; set; }

        public VehiculeRoulant():base()
        {
        }

        // abstract = le code de consommation n'est pas dans cette classe, mais dans une classe dérivée
        // virtual = le code est dans cette classe, mais peut être redéfini (pas obligatoire) dans une classe dérivée.
        public abstract float Consommation();
    }
}
