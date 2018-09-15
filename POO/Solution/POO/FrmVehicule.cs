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
            cbxTypeVehicule.SelectedIndex = 0;
        }

        private VehiculeRoulant Veh;

        private void btnCreation_Click(object sender, EventArgs e)
        {
            if (Veh != null)
            {
                MessageBox.Show("Instance déjà créée");
                return;
            }
            switch (cbxTypeVehicule.Text)
            {
                case "Camion": Veh = new Camion();
                    break;
                case "Voiture": Veh = new Voiture();
                    break;
                case "Moto": Veh = new Moto();
                    break;

                default: throw new Exception(string.Format("Unkown Vehicule Type : {0}", cbxTypeVehicule.Text));
            }
            ToggleButtons();

            txbCharge.Text = Veh.Charge.ToString();
            txbConsoRef.Text = Veh.ConsoRef.ToString();
            txbDistance.Text = Veh.Distance.ToString();
            txbPassagers.Text = Veh.Passagers.ToString();
            txbVitesseMaxi.Text = Veh.VitesseMaxi.ToString();
            txbVitesseMini.Text = Veh.VitesseMini.ToString();
        }

        private void btnDestruction_Click(object sender, EventArgs e)
        {
            Veh = null;
            ToggleButtons();
            // 1ère facon de faire : 
            /*
            txbCharge.Text = "";
            txbConsommation.Text = "";
            txbConsoRef.Text = "";
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

                // On renseigne les différents champs entre 
                try
                {
                    Veh.Distance = Convert.ToInt32(txbDistance.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Erreur dans distance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDistance.Text = Veh.Distance.ToString();
                    txbDistance.Clear();
                    txbDistance.Focus();
                }

                Veh.Charge = Convert.ToInt32(txbCharge.Text);
                Veh.ConsoRef = Convert.ToSingle(txbConsoRef.Text);
                Veh.Passagers = Convert.ToInt32(txbPassagers.Text);
                Veh.VitesseMaxi = Convert.ToSingle(txbVitesseMaxi.Text);
                Veh.VitesseMini = Convert.ToSingle(txbVitesseMini.Text);


                // Calcul de la consommation
                txbConsommation.Text = Veh.Consommation().ToString();
            }
            catch (DistanceException dex)
            {
                MessageBox.Show(dex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
