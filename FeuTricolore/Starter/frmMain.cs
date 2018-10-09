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

            // TODO 3 : Résumé :
            //          Bravo vous venez à l'étape 2 de créer votre propre événement
            //          Maintenant il vous faut l'utiliser (abonner)
            // TODO 3a : S'abonner à l'évenement changement de couleur du feu
            //           Lorsque l'événement se déclenche il faut réaliser les actions suivantes :
            //           Si la nouvelle couleur est verte, démarrer la voiture
            //           sinon l'arreter.
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
