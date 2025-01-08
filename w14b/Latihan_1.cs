using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W14B_Jevon_Valentino_160424066
{
    public partial class Latihan_1 : Form
    {
        public Latihan_1()
        {
            InitializeComponent();
        }
        string[] arrNamaMhs = new string [30];
        int[] arrNilaiUts = new int [30];
        int index = 0;

        private void SimpanData(string pNama, int pNilai)
        {
            arrNamaMhs[index] = pNama;
            arrNilaiUts[index] = pNilai;
            index++;
        }

        private void ResetTextBox()
        {
            txtNamaMhs.Clear();
            nudNilaiUts.ResetText();
            txtNamaMhs.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
            string nama = txtNamaMhs.Text;
            int nilaiUts = (int)nudNilaiUts.Value;
            SimpanData(nama, nilaiUts);
            ResetTextBox();
            MessageBox.Show("Data Saved!", "", MessageBoxButtons.OK);
        }

        private void Tampil()
        {
            string nama;
            int nilai;
            for (int i = 0; i < index; i++)
            {
                nama = arrNamaMhs[i];
                nilai = arrNilaiUts[i];
                lstOut.Items.Add(nama + " - " + nilai);
            }
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            Tampil();
        }

        private double HitungRata()
        {
            double rata;
            int total=0;
            for (int i = 0; i < index; i++)
            {
                total = total + arrNilaiUts[i];   
            }
            rata = total / index;
            return rata;
        }

        private int Max()
        {
            int max = arrNilaiUts[0];
            for (int i = 1; i < index; i++)
            {
                if (max < arrNilaiUts[i])
                {
                    max = arrNilaiUts[i];
                }
            }
            return max;
        }

        private int Min()
        {
            int min = arrNilaiUts[0];
            for (int i = 1; i < index; i++)
            {
                if (min > arrNilaiUts[i])
                {
                    min = arrNilaiUts[i];
                }
            }
            return min;
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
            double rata = HitungRata();
            lstOut.Items.Add("Rata - rata = " + rata);
            int max = Max();
            for (int i = 0; i < index; i++)
            {
                if (arrNilaiUts[i] == max)
                {
                    lstOut.Items.Add(arrNamaMhs[i] + " = " + max);
                }
            }
            int min = Min();
            for (int i = 0; i < index; i++)
            {
                if (arrNilaiUts[i] == min)
                {
                    lstOut.Items.Add(arrNamaMhs[i] + " = " + min);
                }
            }
        }
    }
}
