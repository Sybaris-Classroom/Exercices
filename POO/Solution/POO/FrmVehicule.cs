using POO.Exceptions;
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

        // Illustre l'abstraction
        private VehiculeRoulant vehiculeRoulant;
        private enum VehiculeType { Camion = 1, Voiture = 0, Moto = 2 };

        private void btnCreation_Click(object sender, EventArgs e)
        {
            if (vehiculeRoulant != null)
            {
                MessageBox.Show("Instance déjà créée");
                return;
            }

            VehiculeType vehiculeType = (VehiculeType)cbxTypeVehicule.SelectedIndex;
            switch (vehiculeType)
            {
                case VehiculeType.Camion:
                    vehiculeRoulant = new Camion();
                    break;
                case VehiculeType.Voiture:
                    vehiculeRoulant = new Voiture();
                    break;
                case VehiculeType.Moto:
                    vehiculeRoulant = new Moto();
                    break;

                default: throw new Exception(string.Format("Unkown Vehicule Type : {0}", cbxTypeVehicule.Text));
            }
            ToggleButtons();

            txbCharge.Text = vehiculeRoulant.Charge.ToString();
            txbDistance.Text = vehiculeRoulant.Distance.ToString();
            txbPassagers.Text = vehiculeRoulant.Passagers.ToString();
            txbVitesseMaxi.Text = vehiculeRoulant.VitesseMaxi.ToString();
            txbVitesseMini.Text = vehiculeRoulant.VitesseMini.ToString();
        }

        private void btnDestruction_Click(object sender, EventArgs e)
        {
            vehiculeRoulant = null;
            ToggleButtons();
            // 1ère facon de faire : 
            /*
            txbCharge.Text = "";
            txbConsommation.Text = "";
            txbDistance.Text = "";
            txbPassagers.Text = "";
            txbVitesseMaxi.Text = "";
            txbVitesseMini.Text = "";*/
            // 2ème facon de faire : 
            foreach (var control in gbxVehicule.Controls)
                if (control is TextBox)
                    (control as TextBox).Clear();
        }

        private void ToggleButtons()
        {
            btnConsommation.Enabled = !btnConsommation.Enabled;
            btnCreation.Enabled = !btnCreation.Enabled;
            btnDestruction.Enabled = !btnDestruction.Enabled;
            cbxTypeVehicule.Enabled = !cbxTypeVehicule.Enabled;
        }

        private void btnConsommation_Click(object sender, EventArgs e)
        {
            try
            {
                // On renseigne les différents champs du véhicule avec les valeur rentrée par l'utilisateur dans les textbox
                try
                {
                    vehiculeRoulant.Distance = Convert.ToInt32(txbDistance.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Erreur dans distance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDistance.Text = vehiculeRoulant.Distance.ToString();
                    txbDistance.Clear();
                    txbDistance.Focus();
                }

                vehiculeRoulant.Charge = Convert.ToInt32(txbCharge.Text);
                vehiculeRoulant.Passagers = Convert.ToInt32(txbPassagers.Text);
                vehiculeRoulant.VitesseMaxi = Convert.ToSingle(txbVitesseMaxi.Text);
                vehiculeRoulant.VitesseMini = Convert.ToSingle(txbVitesseMini.Text);

                // Calcul de la consommation
                txbConsommation.Text = vehiculeRoulant.Consommation().ToString();
            }
            catch (DistanceException dex)
            {
                MessageBox.Show(dex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
