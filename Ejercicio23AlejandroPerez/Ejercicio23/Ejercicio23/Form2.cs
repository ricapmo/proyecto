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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 add = new Form3();
            add.ShowDialog();
            if (add.acept)
            {
                list_principal.Items.Add(add.txt_nombre.Text);
            }
        }

        private void eliminarSelecionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list_principal.Items.Remove(list_principal.SelectedItem);
        }

        private void eliminarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list_principal.Items.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
