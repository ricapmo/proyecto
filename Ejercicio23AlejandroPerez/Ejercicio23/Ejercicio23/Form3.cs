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
    public partial class Form3 : Form
    {
        public bool acept = false;

        public Form3()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            acept = false;
            this.Close();
        }

        private void btn_acept_Click(object sender, EventArgs e)
        {
            acept = false;
            this.Close();
        }
    }
}
