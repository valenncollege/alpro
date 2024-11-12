using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W10A_Jevon_Valentino_160424066
{
    public partial class latihan1 : Form
    {
        public latihan1()
        {
            InitializeComponent();
        }

        int[] arrTanggal = new int[31];
        int[] arrJumlahJual = new int[1000];
        int index = 0;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int tanggal = (int)nudTanggal.Value;
            arrTanggal[index] = tanggal;

            int jumlahJual = int.Parse(txtJumlahJual.Text);
            arrJumlahJual[index] = jumlahJual;

            index++;

            txtJumlahJual.Clear();
            nudTanggal.ResetText();
            nudTanggal.Select();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            int tglAwal = (int)nudTanggalAwal.Value;
            int tglAkhir = (int)nudTanggalAkhir.Value;

            for(int i = 0; i < index; i++)
            {
                
                    if (tglAwal <= arrTanggal[i] && tglAkhir >= arrTanggal[i])
                    {
                        lstHasil.Items.Add("Tanggal " + arrTanggal[i] + " terjual = " + arrJumlahJual[i]);
                    }
                
            }
        }

        private void btnTampil2_Click(object sender, EventArgs e)
        {
            lstHasil.Items.Clear();
            int batasBawah = int.Parse(txtBawah.Text);
            int batasAtas = int.Parse(txtAtas.Text);

            for (int i = 0; i < index; i++)
            {
                if (batasBawah <= arrJumlahJual[i] && batasAtas >= arrJumlahJual[i])
                {
                    lstHasil.Items.Add("Tanggal " + arrTanggal[i] + " terjual = " + arrJumlahJual[i]);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int max = 0;
            int min = 100;
            for (int i = 0; i < index; i++)
            {
                if (max < arrJumlahJual[i])
                {
                    max = arrJumlahJual[i];
                }
                if (min > arrJumlahJual[i])
                {
                    min = arrJumlahJual[i];
                }
            }
            lstHasil.Items.Add("Penjualan maksimum = " + max);
            lstHasil.Items.Add("Penjualan minimum = " + min);

        }

        int[] arrJumlah = new int[100];
        int index2 = 0;

        private void btnSimpanPrediksi_Click(object sender, EventArgs e)
        {
            int jumlah = int.Parse(txtPrediksi.Text);

            arrJumlah[index2] = jumlah;

            index2++;
            txtPrediksi.Clear();
            txtPrediksi.Select();
        }

        private void btnPrediksi_Click(object sender, EventArgs e)
        {
            lstHasil.Items.Clear();
            double nilai1 = arrJumlah[index2 - 1];
            double nilai2 = arrJumlah[index2 - 2];
            double nilai3 = arrJumlah[index2 - 3];

            double prediksi = (nilai1 + nilai2 + nilai3) / 3;
            prediksi = Math.Round(prediksi,2);
            if (index2 >= 2)
            {
                lstHasil.Items.Add("Prediksi jumlah yang terjual pada hari ke " + (index2+1) + " = " + prediksi);
            }
            else
            {
                lstHasil.Items.Add("Data tidak cukup untuk prediksi");
            }
        }
    }
}
