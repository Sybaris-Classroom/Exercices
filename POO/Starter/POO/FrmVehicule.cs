using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class FrmVehicule : Form
    {
        public FrmVehicule()
        {
            InitializeComponent();
        }

        private void FrmVehicule_Load(object sender, EventArgs e)
        {
            // Pour forcer la combobox à sélectionner un élément
            cbxTypeVehicule.SelectedIndex = 0;
        }

        // TODO 1 (POO) : Créer les classes suivantes :
        // - VehiculeAMoteur
        // - VehiculeRoulant
        // - Moto
        // - Voiture
        // - Camion
        // Chaque classe doit être dans un fichier séparé du même nom que la classe

        // TODO 2 (Winform/UI) : Dans ce fichier (classe FrmVehicule), coder :
        // - Le boutton Creation
        //   - En fonction du choix dans la combobox cbxTypeVehicule, créer le véhicule correspondant.
        //   - Le stocker sous forme d'un champ de la classe FrmVehicule
        //   - Renseigner les textbox (sauf consommation) avec les valeurs des champs/propriétés du véhicule précédemment créé
        // - Le boutton Consommation
        //   - Lire les textbox et renseigner les valeurs des champs/propriétés du véhicule précédemment avec la valeur des textbox correspondantes
        //   - Appeller la méthode consommation (et donc utiliser le polymorphisme)
        //   - Capturer les Exceptions pour le champ distance de type FormatException (cas de saisie de texte au lieu de numérique)
        //     et afficher un Message "Erreur de format dans le champ distance"
        //   - Capturer les Exceptions pour le champ distance de type DistanceException (cas de saisie <0 ou >2000)
        //     et afficher un Message de type Warning
        // - Le boutton Destruction
        //   - L'idée de ce boutton est juste de gérer correctement l'interface graphique : ce boutton est grisé tant qu'un véhicule n'est pas créé.
    }
}
