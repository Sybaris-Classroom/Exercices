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
    }
}
