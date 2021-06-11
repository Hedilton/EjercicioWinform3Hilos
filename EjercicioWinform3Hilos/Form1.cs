using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EjercicioWinform3Hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls =false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread x = new Thread(new ThreadStart(metodo1));
            Thread y = new Thread(new ThreadStart(metodo2));
            x.Start();y.Start();
        }
        public void metodo1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(3000);
                this.picture.Visible = false;
                Thread.Sleep(3000);
                this.picture.Visible = true;

            }
            this.checkBox1.Checked = true;
        }
        public void metodo2()
        {
            for (int y = 1; y <= 5; y++)
            {
                Thread.Sleep(3000);
                this.picture2.Visible = true;
                Thread.Sleep(3000);
                this.picture2.Visible = false;
            }
            this.picture2.Visible = true;
            this.checkBox2.Checked = true;
        }
    }
}
