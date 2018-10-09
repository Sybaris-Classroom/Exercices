using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventFeuTricolore
{
    /// <summary>
    /// Cette classe dessine et gère un feu Tricolore
    /// </summary>
    public class FeuTricolore
    {
        /// <summary>
        /// Les différents états/couleurs du feu
        /// </summary>
        public enum FeuTricoloreEnum { Eteint, Vert, Orange, Rouge };

        /// <summary>
        /// Durées en millisecondes de chaque couleurs du feu tricolore
        /// </summary>
        private readonly Dictionary<FeuTricoloreEnum, int> DUREE = new Dictionary<FeuTricoloreEnum, int>() {
                { FeuTricoloreEnum.Vert, 4000 },
                { FeuTricoloreEnum.Orange, 1500 },
                { FeuTricoloreEnum.Rouge, 4000 }
            };

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="aGraphics">Zone de dessin</param>
        public FeuTricolore(Graphics aGraphics)
        {
            graphics = aGraphics;
            DessineFeuTricolore();
        }

        #region Champs
        /// <summary>
        /// Zone de dessin
        /// </summary>
        private Graphics graphics;
        /// <summary>
        /// Timer qui permet de chronométrer chaque temps entre les différentes couleurs
        /// </summary>
        private Timer timer = new Timer();
        /// <summary>
        /// Couleur du feu
        /// </summary>
        private FeuTricoloreEnum couleurActuelle = FeuTricoloreEnum.Eteint;
        #endregion Champs

        public void Start()
        {
            // La première couleur sera le vert
            CouleurActuelle = FeuTricoloreEnum.Vert;
            
            // Redessine le feu
            DessineFeuTricolore();

            // Créé le timer 
            timer = new Timer();

            // Abonne la méthode Timer_Tick afin qu'elle se déclenche lorsque le temps imparti sera écoulé
            timer.Tick += Timer_Tick;

            // Fixe le temps imparti avant le déclenchement de l'événement Tick
            timer.Interval = DUREE[FeuTricoloreEnum.Vert];

            // Démarre le timer
            timer.Start();
        }

        public void Stop()
        {
            // On arrete le feu
            CouleurActuelle = FeuTricoloreEnum.Eteint;
            
            // On arrete le timer
            if (timer != null)
            {
                timer.Stop();
                timer = null;
            }
        }

        /// <summary>
        /// Code qui va être appelé par l'événement Tick du Timer lorsque le temps imparti sera écoulé
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Arrete le timer le temps qu'on change la couleur et qu'on lui parametre le nouveau temps d'attente
            timer.Stop();
            
            // Modifie la couleur du feu en passant à la couleur suivante
            CouleurActuelle = CouleurSuivante();

            // Fixe la nouvelle durée d'attente en fonction de la couleur actuelle
            timer.Interval = DUREE[CouleurActuelle];

            // Redémarre le timer
            timer.Start();
        }

        /// <summary>
        /// Gestion de l'état suivant. C'est ici qu'est contenu la logique de la machine a état...
        /// </summary>
        /// <returns></returns>
        private FeuTricoloreEnum CouleurSuivante()
        {
            switch (couleurActuelle)
            {
                case FeuTricoloreEnum.Eteint:
                case FeuTricoloreEnum.Vert:
                    return FeuTricoloreEnum.Orange;
                case FeuTricoloreEnum.Orange:
                    return FeuTricoloreEnum.Rouge;
                case FeuTricoloreEnum.Rouge:
                    return FeuTricoloreEnum.Vert;
                default:
                    throw new NotImplementedException("Couleur inconnue : " + couleurActuelle);
            }
        }

        /// <summary>
        /// Propriété couleur actuelle. Lorsque la couleur change, redessine le feu tricolore et déclenche un événement
        /// </summary>
        public FeuTricoloreEnum CouleurActuelle
        {
            get
            {
                return couleurActuelle;
            }
            set
            {
                // Si pas de changement de couleur, ne fait rien
                if (couleurActuelle == value)
                    return;

                // Modifie le champ contenant la couleur du feu
                couleurActuelle = value;

                // Redessine le feu
                DessineFeuTricolore();
            }
        }

        /// <summary>
        /// Dessine le feu tricolore en fonction du feu allumé
        /// </summary>
        public void DessineFeuTricolore()
        {
            Graphics g = graphics;

            g.FillRectangle(Brushes.LightGray, new Rectangle(0, 0, 80, 200));
            Rectangle r = new Rectangle(10, 10, 60, 180);
            g.FillRectangle(Brushes.DarkGray, r);
            Rectangle r1 = new Rectangle(12, 12, 56, 56);
            Rectangle r2 = new Rectangle(12, 70, 56, 56);
            Rectangle r3 = new Rectangle(12, 128, 56, 56);
            switch (couleurActuelle)
            {
                case FeuTricoloreEnum.Rouge:
                    g.FillEllipse(Brushes.Red, r1);
                    g.FillEllipse(Brushes.Black, r2);
                    g.FillEllipse(Brushes.Black, r3);
                    break;
                case FeuTricoloreEnum.Orange:
                    g.FillEllipse(Brushes.Black, r1);
                    g.FillEllipse(Brushes.Orange, r2);
                    g.FillEllipse(Brushes.Black, r3);
                    break;
                case FeuTricoloreEnum.Vert:
                    g.FillEllipse(Brushes.Black, r1);
                    g.FillEllipse(Brushes.Black, r2);
                    g.FillEllipse(Brushes.Green, r3);
                    break;
                case FeuTricoloreEnum.Eteint:
                    g.FillEllipse(Brushes.Black, r1);
                    g.FillEllipse(Brushes.Black, r2);
                    g.FillEllipse(Brushes.Black, r3);
                    break;
                default:
                    throw new NotImplementedException("Couleur inconnue : " + couleurActuelle);
            }
        }
    }

}
