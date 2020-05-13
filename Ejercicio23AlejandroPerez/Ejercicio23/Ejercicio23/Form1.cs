using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void lISTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lista = new Form2();
            lista.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿Desea salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fORMATOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editor = new Form4();
            editor.ShowDialog();
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
