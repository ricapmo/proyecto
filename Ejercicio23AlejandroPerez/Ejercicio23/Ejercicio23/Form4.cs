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
    public partial class Form4 : Form
    {
        bool negrita = false;
        bool cursiva = false;
        bool sub = false;

        public Form4()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            lbl_txt.Font = new Font(lbl_txt.Font.Name, 12, lbl_txt.Font.Style);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            lbl_txt.Font = new Font(lbl_txt.Font.Name, 14, lbl_txt.Font.Style);

        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            lbl_txt.Font = new Font(lbl_txt.Font.Name, 16, lbl_txt.Font.Style);

        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            lbl_txt.Font = new Font(lbl_txt.Font.Name, 18, lbl_txt.Font.Style);

        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            lbl_txt.Font = new Font(lbl_txt.Font.Name, 20, lbl_txt.Font.Style);

        }

        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarNegrita();
        }

        private void cursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarCursiva();
        }

        private void subrayadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarSubrayado();
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_txt.Font = new Font("Arial", lbl_txt.Font.Size, lbl_txt.Font.Style);
        }

        private void newTimesRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_txt.Font = new Font("Times New Roman", lbl_txt.Font.Size, lbl_txt.Font.Style);
        }

        private void courierNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_txt.Font = new Font("Courier New", lbl_txt.Font.Size, lbl_txt.Font.Style);
        }

        private void Ctx_Item12_Click(object sender, EventArgs e)
        {
            lbl_txt.Font = new Font(lbl_txt.Font.Name, 12, lbl_txt.Font.Style);
        }

        private void Ctx_Item14_Click(object sender, EventArgs e)
        {
            lbl_txt.Font = new Font(lbl_txt.Font.Name, 14, lbl_txt.Font.Style);
        }

        private void Ctx_Item16_Click(object sender, EventArgs e)
        {
            lbl_txt.Font = new Font(lbl_txt.Font.Name, 16, lbl_txt.Font.Style);
        }

        private void Ctx_Item18_Click(object sender, EventArgs e)
        {
            lbl_txt.Font = new Font(lbl_txt.Font.Name, 18, lbl_txt.Font.Style);
        }

        private void Ctx_Item20_Click(object sender, EventArgs e)
        {
            lbl_txt.Font = new Font(lbl_txt.Font.Name, 20, lbl_txt.Font.Style);
        }

        private void tool_Negrita_Click(object sender, EventArgs e)
        {
            cambiarNegrita();
        }

        private void tool_Cursiva_Click(object sender, EventArgs e)
        {
            cambiarCursiva();
        }

        private void tool_Subrayado_Click(object sender, EventArgs e)
        {
            cambiarSubrayado();
        }

        private void cambiarNegrita()
        {
            if (negrita == false)
            {
                negrita = true;
                tool_Negrita.Checked = true;
                lbl_txt.Font = new Font(lbl_txt.Font, lbl_txt.Font.Style | FontStyle.Bold);
            }
            else
            {
                negrita = false;
                tool_Negrita.Checked = false;
                lbl_txt.Font = new Font(lbl_txt.Font, lbl_txt.Font.Style ^ FontStyle.Bold);
            }
        }

        private void cambiarCursiva()
        {
            if (cursiva == false)
            {
                cursiva = true;
                tool_Cursiva.Checked = true;
                lbl_txt.Font = new Font(lbl_txt.Font, lbl_txt.Font.Style | FontStyle.Italic);
            }
            else
            {
                cursiva = false;
                tool_Cursiva.Checked = false;
                lbl_txt.Font = new Font(lbl_txt.Font, lbl_txt.Font.Style ^ FontStyle.Italic);
            }
        }

        private void cambiarSubrayado()
        {
            if (sub == false)
            {
                sub = true;
                tool_Subrayado.Checked = true;
                lbl_txt.Font = new Font(lbl_txt.Font, lbl_txt.Font.Style | FontStyle.Underline);
            }
            else
            {
                sub = false;
                tool_Subrayado.Checked = false;
                lbl_txt.Font = new Font(lbl_txt.Font, lbl_txt.Font.Style ^ FontStyle.Underline);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
