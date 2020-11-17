using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventFeuTricolore
{
    public partial class frmMain : Form
    {
        private FeuTricolore feuTricolore;
        private Voiture voiture;

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Au chargement du formulaire
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Pour que la voiture soit transparente
            pbxVoiture.Parent = pbxCircuit;
            pbxVoiture.Location = new Point(pbxVoiture.Location.X - pbxVoiture.Parent.Location.X, pbxVoiture.Location.Y - pbxVoiture.Parent.Location.Y);
            pbxVoiture.BackColor = Color.Transparent;
            // Affiche le feu tricolore
            feuTricolore = new FeuTricolore(pbxFeuTricolore.CreateGraphics());
            // Créé la voiture
            voiture = new Voiture(pbxVoiture);
            // S'abonne à l'évenement changement de couleur du feu
            feuTricolore.ColorChanged += FeuTricolore_ColorChanged;
        }

        /// <summary>
        /// Implémentation de l'événement pour s'abonner au changement de couleur du feu
        /// Quand le feu est vert, la voiture démarre.
        /// Pour toutes les autres couleurs, la voiture s'arrete.
        /// </summary>
        /// <param name="sender">Le feu tricolore qui déclenche l'événement</param>
        /// <param name="newColor">La nouvelle couleur du feu</param>
        /// <param name="oldColor">La couleur précédente du feu</param>
        private void FeuTricolore_ColorChanged(FeuTricolore sender, FeuTricolore.FeuTricoloreEnum newColor, FeuTricolore.FeuTricoloreEnum oldColor)
        {
            if (newColor == FeuTricolore.FeuTricoloreEnum.Vert)
                voiture.Start();
            else
                voiture.Stop();
        }


        /// <summary>
        /// Quand le jeu est "on", démarre le feu tricolore
        /// Sinon l'arrete.
        /// </summary>
        /// <param name="isPlaying"></param>
        private void Play(bool isPlaying)
        {
            if (isPlaying)
                feuTricolore.Start();
            else
                feuTricolore.Stop();
        }

        /// <summary>
        /// Se déclenche lorsque la checkbox change d'état
        /// </summary>
        private void chkGo_CheckedChanged(object sender, EventArgs e)
        {
            Play(chkGo.Checked);
        }
    }
}
