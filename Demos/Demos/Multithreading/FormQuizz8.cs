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

namespace Demos.Multithreading
{
    public partial class FormQuizz8 : Form
    {
        public FormQuizz8()
        {
            InitializeComponent();
        }

        object A = new object();

        private void FormQuizz8_Load(object sender, EventArgs e)
        {
            Text = "Text1";
            Task.Run(new Action(UpdateUIByInvoke));
            Thread.Sleep(100);
            lock (A) { };
        }
        private void UpdateUIByInvoke()
        {
            lock (A)
                Invoke(new Action(UpdateUI));
        }
        private void UpdateUI()
        {
            Text = "Text2";
        }
    }
}
