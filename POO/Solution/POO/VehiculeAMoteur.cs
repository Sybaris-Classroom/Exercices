using POO.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class VehiculeAMoteur
    {
        private int m_distance;
        public int Distance 
        { 
            get { return m_distance; } 
            set 
            {
                if (value < 0)
                    throw new DistanceException("Distance négative");
                if (value >2000)
                    throw new DistanceException("Distance exagérée");
                m_distance = value; 
            } 
        }
        public float VitesseMaxi { get; set; }
        public float VitesseMini { get; set; }

        protected VehiculeAMoteur()
        {
            Distance = 1000;
            VitesseMaxi = 180;
            VitesseMini = 90;
        }

        protected VehiculeAMoteur(int aDistance, float aVitesseMoyenne, float aVitesseMaxi)
        {
            Distance = 1000;
            VitesseMaxi = 180;
            VitesseMini = 90;
        }

    }
}
