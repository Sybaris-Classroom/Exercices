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
        // TODO 2 : Résumé : 
        //          L'objectif est de créer un événement qui signale le changement de couleur/d'état du feu.
		//          Pour la syntaxe, voir : https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-publish-events-that-conform-to-net-framework-guidelines
        //          L'idée est que la voiture pourra s'abonner à cet événement.
        //          Dans la 1ère partie vous avez utilisé (abonné) l'événement du timer
        //          Dans cette 2ème partie, on va créer un nouvel événement (ColorChanged) afin de voir comment on implémente un événement.

        /// <summary>
        /// Déclaration d'un type delegate (signature) pour le changement de couleur d'un feu tricolore
        /// </summary>
        /// <param name="sender">Le feu tricolore qui déclenche l'événement</param>
        /// <param name="newColor">La nouvelle couleur du feu</param>
        /// <param name="oldColor">La précédente couleur du feu</param>
        // TODO 2a : Déclarer la signature de l'événement. La signature doit avoir 3 paramètres : (FeuTricolore sender, FeuTricoloreEnum newColor, FeuTricoloreEnum oldColor)

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
        /// Evénement que déclenche le feu tricolore lorsque la couleur change
        /// </summary>
        // TODO 2b : déclarer l'événement et le nommer "ColorChanged"
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

            // TODO 1 : Résumé :
            //          Ici l'objectif est de faire fonctionner le feu tricolore. Pour cela on va utiliser un Timer.
            //          Le timer va permettre d'attendre une certaine durée entre chaque changement de couleur du feu.

            // TODO 1a : Créer le timer (Ex : https://docs.microsoft.com/fr-fr/dotnet/api/system.windows.forms.timer?view=netframework-4.8)

            // TODO 1b : S'abonner à l'événement Tick
            //           Lorsque l'événement se déclenche il faut réaliser les actions suivantes :
            //           1°/ Arreter le timer (le temps qu'on change la couleur et qu'on lui parametre le nouveau temps d'attente)
            //           2°/ Modifier la couleur du feu en passant à la couleur suivante (Utiliser la méthode CouleurSuivante())
            //           3°/ Fixer la nouvelle durée d'attente en fonction de la couleur actuelle (Utiliser le dictionnaire DUREE)
            //           4°/ Redémarrer le timer

            // TODO 1c : Fixer le temps imparti au timer avant le déclenchement de l'événement Tick

            // TODO 1d : Démarre le timer
        }

        public void Stop()
        {
            // On arrete le feu
            CouleurActuelle = FeuTricoloreEnum.Eteint;

            // TODO 1e : Arreter le timer
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

                // TODO 2c : Si il y a un ou des abonnés à l'événement, lève l'événement ColorChanged

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
