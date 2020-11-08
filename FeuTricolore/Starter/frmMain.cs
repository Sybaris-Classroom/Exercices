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
        private void Form1_Load(object sender, EventArgs e)
        {
            // Pour que la voiture soit transparente
            pbxVoiture.Parent = pbxCircuit;
            pbxVoiture.Location = new Point(pbxVoiture.Location.X - pbxVoiture.Parent.Location.X, pbxVoiture.Location.Y - pbxVoiture.Parent.Location.Y);
            pbxVoiture.BackColor = Color.Transparent;
            // Affiche le feu tricolore
            feuTricolore = new FeuTricolore(pbxFeuTricolore.CreateGraphics());
            // Créé la voiture
            voiture = new Voiture(pbxVoiture);

            // TODO 4 : Résumé :
            //          Bravo vous venez à l'étape 2 de créer votre propre événement
            //          Maintenant il vous faut l'utiliser (abonner)
            // TODO 4a : S'abonner à l'évenement changement de couleur du feu
            // TODO 4b : Lorsque l'événement se déclenche il faut réaliser les actions suivantes :
            //           Si la nouvelle couleur est verte, démarrer la voiture
            //           sinon l'arreter.

            // TODO 5 : Bravo vous avez terminé l'exercice. En bonus, vous pouvez regarder la solution "DemoSansEventPolling"
            //          qui montre une implémentation avec une technique appelée le "polling". Ce type d'implémentation a 
            //          l'inconvénient de boucler sans arret en demandant à intervalle régulier l'état du feu tricolore.
            //          Cela surcharge le feu tricolore d'appels qui dans certains scenarios peuvent être problématique.
            //          De plus cela créé un couplage entre la voiture et le feu tricolore, ce qui rend les classes dépedantes
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

        // TODO 1 : Résumé : 
        //          L'objectif est de générer un événement par le designer de Visual Studio et d'observer comment est contruit cet abonnement
        // TODO 1a : Aller sur le formulaire et double clicker sur la checkbox chkGo. Cela va générer un événement chkGo_CheckedChanged
        // TODO 1b : Dans cet événement, rajouter le code suivant :  Play(chkGo.Checked);
        //           Pour ce todo, il n'y a plus rien à coder. Le reste est de l'observation (lecture) pour vous aider à comprendre
        // TODO 1c : Chercher les références (Shift-F12) à cet événement chkGo_CheckedChanged, et regarder dans le Designer.cs comment se fait l'abonnement.
        //           La ligne de code recherchée est : "this.chkGo.CheckedChanged += new System.EventHandler(this.chkGo_CheckedChanged);"
        //           Notez le signe += pour un abonnement à un événement
        // TODO 1d : Allez à la définition de EventHandler (F12)
        //           La ligne de code recherchée est "public delegate void EventHandler(object sender, EventArgs e);"
        //           Il s'agit de la signature de l'événement.
        //           Notez que les parametres sont identiques à l'événement généré chkGo_CheckedChanged. Si ce n'était pas le cas, le compilateur déclencherait une erreur.
        // TODO 1e : Ici vous avez utilisé un événement prédéfini par le framework.
        //           Dans les prochaines étapes, vous allez créer un événement "from scratch"

    }
}
