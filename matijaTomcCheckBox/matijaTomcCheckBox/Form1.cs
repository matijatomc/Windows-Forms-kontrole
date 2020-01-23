using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matijaTomcCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtPosalji_Click(object sender, EventArgs e)
        {
            txtPrikaz.Clear();
            txtPrikaz.Text = "Odarali ste:";
            if (chbDorucak.Checked)
            {
                txtPrikaz.AppendText("\r\ndoručak");
            }

            if (chbRucak.Checked)
            {
                txtPrikaz.AppendText("\r\nrucak");
            }

            if (chbVecera.Checked)
            {
                txtPrikaz.AppendText("\r\nvecera");
            }

            if (chbSakriNarudzbu.Checked)
            {
                txtPrikaz.Clear();
            }
        }

        private void TxtPrikaz_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChbSakriNarudzbu_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbSakriNarudzbu.Checked)
            {
                txtPrikaz.Text = "Odarali ste:";
                if (chbDorucak.Checked)
                {
                    txtPrikaz.AppendText("\r\ndoručak");
                }

                if (chbRucak.Checked)
                {
                    txtPrikaz.AppendText("\r\nrucak");
                }

                if (chbVecera.Checked)
                {
                    txtPrikaz.AppendText("\r\nvecera");
                }

            }
            else
            {
                txtPrikaz.Clear();
            }
        }
    }
}
