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
        /// Au chargement fu formulaire
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
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
        /// Se déclenche lorsque la checkbox change d'état
        /// Quand la checkbox est cochée, démarre le feu tricolore
        /// Sinon l'arrete.
        /// </summary>
        private void chkGo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGo.Checked)
                feuTricolore.Start();
            else
                feuTricolore.Stop();
        }

    }
}
