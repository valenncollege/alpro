using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W13A_Jevon_Valentino_160424066
{
    public partial class Latihan_3 : Form
    {
        public Latihan_3()
        {
            InitializeComponent();
        }
        double diskon, totalBayar;
        //method diskon di tanggal 3
        private double Diskon_Tanggal_3 (int A)
        {
            if (cmbKartu.Text == "Silver")
            {
                diskon = 0.1 * A;
            }
            else if (cmbKartu.Text == "Gold")
            {
                diskon = 0.15 * A;
            }
            else
            {
                diskon = 0;
            }
            return diskon;
        }
        //method diskon tgl 17
        private double Diskon_Tanggal_17(int A)
        {
            if (cmbKartu.Text == "Silver")
            {
                diskon = 0.09 * A;
            }
            else if (cmbKartu.Text == "Gold")
            {
                diskon = 0.12 * A;
            }
            else
            {
                diskon = 0;
            }
            return diskon;
        }

        private double Diskon_Tanggal_29(int A)
        {
            if (cmbKartu.Text == "Silver")
            {
                diskon = 0.06 * A;
            }
            else if (cmbKartu.Text == "Gold")
            {
                diskon = 0.2 * A;
            }
            else
            {
                diskon = 0;
            }
            return diskon;
        }

        //method biaya bayar
        private double Total(int pNominal, double pDiskon)
        {
            double total = pNominal - pDiskon;
            return total;
        }
        //method output
        private void Tampil()
        {
            lstOut.Items.Add("Total diskon = " + diskon);
            lstOut.Items.Add("Total bayar = " + totalBayar);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
            int nominal = int.Parse(txtNominal.Text);
            if (nudTanggal.Value == 3)
            {
                Diskon_Tanggal_3(nominal);
                totalBayar = Total(nominal, diskon);
            }
            else if (nudTanggal.Value == 17)
            {
                Diskon_Tanggal_17(nominal);
                totalBayar = Total(nominal, diskon);
            }
            else if (nudTanggal.Value == 29)
            {
                Diskon_Tanggal_29(nominal);
                totalBayar = Total(nominal, diskon);
            }
            else
            {
                diskon = 0;
                totalBayar = Total(nominal, diskon);
            }
            Tampil();
        }
    }
}
