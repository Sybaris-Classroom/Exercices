using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventFeuTricolore
{
    /// <summary>
    /// Cette classe dessine et gère une voiture
    /// </summary>
    public class Voiture
    {
        #region Champs
        /// <summary>
        /// Dessin de la voiture
        /// </summary>
        private PictureBox pbxVoiture;
        /// <summary>
        /// Point initial du dessin de la voiture avant tout déplacement
        /// </summary>
        private Point initialPoint;
        /// <summary>
        /// Pas beau : la voiture dépend du feu tricolore
        /// </summary>
        private FeuTricolore feuTricolore;
        /// <summary>
        /// Limite en pixel du circuit de la voiture
        /// </summary>
        private readonly Rectangle LimitesCircuitVoiture = new Rectangle(0, 0, 400, 250);
        /// <summary>
        /// Liste de tous les points où va passer la voiture sur le circuit
        /// </summary>
        private List<Point> positionVoitureListe = null;
        /// <summary>
        /// Poistion courante dans la liste des points où se situe la voiture
        /// </summary>
        private int positionVoitureIndex = 0;
        #endregion Champs

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="aPictureBox">Dessin de la voiture</param>
        public Voiture(PictureBox aPictureBox, FeuTricolore aFeuTricolore)
        {
            // Ici on créé une dépendance entre le feu tricolore et la voiture
            pbxVoiture = aPictureBox;
            initialPoint = pbxVoiture.Location;
            feuTricolore = aFeuTricolore;

        }
        private bool actif = false;
        /// <summary>
        /// Démarre la voiture
        /// </summary>
        public void Start()
        {
            actif = true;
            // Polling
            while (actif)
            {
                // Même dans le cas où la voiture doit attendre, on scrute sans arret l'état du feu tricolore
                VoiturePositionSuivante();
                Thread.Sleep(10);
                Application.DoEvents();
            }
        }

        /// <summary>
        /// Stoppe la voiture
        /// </summary>
        public void Stop()
        {
            actif = false;
        }

        /// <summary>
        /// Calcule tous les points du circuit de la voiture
        /// </summary>
        IEnumerable<Point> PositionVoiture()
        {
            // Notez ici l'utilisation du yield return --> C.F. Demo yield return
            for (int i = LimitesCircuitVoiture.Left; i < LimitesCircuitVoiture.Right; i++)
                yield return new Point(i, LimitesCircuitVoiture.Top);
            for (int i = LimitesCircuitVoiture.Top; i < LimitesCircuitVoiture.Bottom; i++)
                yield return new Point(LimitesCircuitVoiture.Right, i);
            for (int i = LimitesCircuitVoiture.Right; i > LimitesCircuitVoiture.Left; i--)
                yield return new Point(i, LimitesCircuitVoiture.Bottom);
            for (int i = LimitesCircuitVoiture.Bottom; i > LimitesCircuitVoiture.Top; i--)
                yield return new Point(LimitesCircuitVoiture.Left, i);
        }

        /// <summary>
        /// Positionne la voiture sur le point suivant
        /// </summary>
        private void VoiturePositionSuivante()
        {
            if (feuTricolore.CouleurActuelle != FeuTricolore.FeuTricoloreEnum.Vert)
                return;

            // Lors du premier appel, initialise la liste des points
            if (positionVoitureListe == null)
            {
                // La méthode d'extension ToList() fait évaluer complètement l'énumération, et donc stocke 
                // en mémoire la liste de tous les points par lesquels la voiture doit passer.
                positionVoitureListe = PositionVoiture().ToList();
            }

            // Si on a fait le tour du circuit, on recommence depuis le début
            if (positionVoitureIndex >= positionVoitureListe.Count)
                positionVoitureIndex = 0;
            
            // Déplace l'image à la position voulue
            Point position = positionVoitureListe[positionVoitureIndex];
            pbxVoiture.Left = initialPoint.X + position.X;
            pbxVoiture.Top = initialPoint.Y + position.Y;

            // On peut passer à la position suivante de la liste
            positionVoitureIndex++;
        }

    }
}
