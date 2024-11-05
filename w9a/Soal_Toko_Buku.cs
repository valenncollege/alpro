using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W9B_Jevon_Valentino_160424066
{
    public partial class TokoBuku : Form
    {
        public TokoBuku()
        {
            InitializeComponent();
        }

        private void TokoBuku_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double harga = double.Parse(txtHarga.Text);
            double jumlah = double.Parse(txtJumlah.Text);
            double ongkir = double.Parse(txtOngkir.Text);

            double total = (harga * jumlah) + ongkir;

            lblAnswer.Text = "Rp " + total.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHarga.Text = "";
            txtJumlah.Text = "";
            txtOngkir.Text = "";
            lblAnswer.Text = "Answer";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Do you want to close this window ?", "Close Window", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtHarga.Text = "";
                txtJumlah.Text = "";
                txtOngkir.Text = "";
                lblAnswer.Text = "Answer";
            }

        }
    }
}
