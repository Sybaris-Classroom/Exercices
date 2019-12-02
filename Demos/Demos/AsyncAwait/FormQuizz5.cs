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

namespace Demos.AsyncAwait
{
    public partial class FormQuizz5 : Form
    {
        public FormQuizz5()
        {
            InitializeComponent();
        }
        public static void Log()
        {
            Console.WriteLine($"Thread Id = {Thread.CurrentThread.ManagedThreadId}");
        }


        private async void FormQuizz5_Load(object sender, EventArgs e)
        {
            Console.WriteLine("SynchronizationContext = "
+ ((SynchronizationContext.Current == null) ? "NULL" : "EXISTS"));

            Log();
            await Task.Delay(100).ConfigureAwait(false);
            Log();

        }
    }
}
