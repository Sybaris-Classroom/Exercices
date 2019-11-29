using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demos.Multithreading
{
    public partial class FormQuizz7 : Form
    {
        public FormQuizz7()
        {
            InitializeComponent();
        }

        private void FormQuizz7_Load(object sender, EventArgs e)
        {
            Text = "Text1";
            Task.Run((Action)UpdateUI);
            // Task.Run((Action)UpdateUIByInvoke); Quizz 7b
        }
        private void UpdateUI()
        {
            Text = "Text2";
        }

        // Quizz 7b
        //private void UpdateUIByInvoke()
        //{
        //    Invoke(new Action(UpdateUI));
        //}


    }
}
