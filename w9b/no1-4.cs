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
    public partial class tugas_w9b : Form
    {
        public tugas_w9b()
        {
            InitializeComponent();
        }
        int[] arrTanggal = new int[30];
        int[] arrBulan = new int[12];
        int[] arrJumlah = new int[100];
        int jumlahInput = 0;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int tanggal = int.Parse(txtTanggal.Text);
            int bulan = int.Parse(txtBulan.Text);
            int jumlahPenjualan = int.Parse(txtJumlah.Text);

            arrTanggal[jumlahInput] = tanggal;
            arrBulan[jumlahInput] = bulan;
            arrJumlah[jumlahInput] = jumlahPenjualan;

            jumlahInput++;

            txtTanggal.Clear();
            txtBulan.Clear();
            txtJumlah.Clear();
            txtTanggal.Select();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            for (int i=0; i < jumlahInput; i++)
            {
                lstOut.Items.Add("Tanggal : " + arrTanggal[i]);
                lstOut.Items.Add("Bulan : " + arrBulan[i]);
                lstOut.Items.Add("Jumlah penjualan : " + arrJumlah[i]);
                lstOut.Items.Add("");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (txtBulan.Text == "")
            {
                for (int i = 0; i < jumlahInput; i++)
                {
                    total = total + arrJumlah[i];
                }
                lstOut.Items.Add("Total penjualan = " + total);

            }
            else
            {
                int bulan = int.Parse(txtBulan.Text);
                for (int i = 0; i < jumlahInput; i++)
                {
                    if (arrBulan[i] == bulan)
                    {
                        total = total + arrJumlah[i];
                    }
                }
                lstOut.Items.Add("Total penjualan = " + total);
            }

        }

        private void btnRata_Click(object sender, EventArgs e)
        {
            double total = 0, rata=0;
            if (txtBulan.Text == "")
            {
                for (int i = 0; i < jumlahInput; i++)
                {
                    total = total + arrJumlah[i];
                }
                rata = total / jumlahInput;
            }
            else
            {
                int count = 0;
                int bulan = int.Parse(txtBulan.Text);
                for (int i = 0; i < jumlahInput; i++)
                {
                    if (arrBulan[i] == bulan)
                    {
                        total = total + arrJumlah[i];
                        count++;
                    }
                }
                rata = total / count;
            }
            double hasilRata = Math.Round(rata, 2);
            lstOut.Items.Add("Rata - rata penjualan = " + hasilRata);



        }

        private void btnDiAtas1_Click(object sender, EventArgs e)
        {
            double rata = 0, total=0;
            for (int i = 0; i < jumlahInput; i++)
            {
                total = total + arrJumlah[i];
            }
            rata = total / jumlahInput;
            int under = 0,upper = 0;

            for (int i = 0; i < jumlahInput; i++)
            {
                if (arrJumlah[i] < rata)
                {
                    under++;
                }
                else
                {
                    upper++;
                }
            }
            double hasilRata = Math.Round(rata, 2);
            lstOut.Items.Add("Rata-rata penjualan = " + hasilRata);
            lstOut.Items.Add("Jumlah hari yang melebihi rata-rata : " + upper);
            lstOut.Items.Add("Jumlah hari kurang dari rata-rata : " + under);

        }

        private void btnDiAtas2_Click(object sender, EventArgs e)
        {
            double rata = 0, total = 0;
            for (int i = 0; i < jumlahInput; i++)
            {
                total = total + arrJumlah[i];
            }
            rata = total / jumlahInput;

            double hasilRata = Math.Round(rata, 2);
            lstOut.Items.Add("Rata-rata penjualan = " + hasilRata);

            lstOut.Items.Add("Penjualan yang melebihi rata-rata : ");
            for (int i = 0; i < jumlahInput; i++)
            {
                if (arrJumlah[i] > rata)
                {
                    lstOut.Items.Add("Tanggal " + arrTanggal[i] + " bulan " + arrBulan[i] + " : " + arrJumlah[i]);
                }
            }
        }
    }
}
