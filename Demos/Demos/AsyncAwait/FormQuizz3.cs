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
    public partial class FormQuizz3 : Form
    {
        public FormQuizz3()
        {
            InitializeComponent();
        }

        public void Log()
        {
            Console.WriteLine($"Thread Id = {Thread.CurrentThread.ManagedThreadId}");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                Log();
                await Task.Delay(100);
                Log();
                Console.WriteLine("...");
            });
        }

    }
}
