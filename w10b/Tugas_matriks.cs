using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W10B_Jevon_Valentino_160424066
{
    public partial class Tugas_matriks : Form
    {
        public Tugas_matriks()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int[,] arrMatriks1;
        int baris1, kolom1;
        int[,] arrMatriks2;
        int baris2, kolom2;

        private void btnProses2_Click(object sender, EventArgs e)
        {
            lstOut2.Items.Clear();
            //masukkan isi nilai ke dalam array
            int baris = int.Parse(cmbBaris2.Text);
            int kolom = int.Parse(cmbKolom2.Text);
            int nilai = (int)nudIsiMatriks2.Value;
            arrMatriks2[(baris - 1), (kolom - 1)] = nilai;

            string temp;
            for (int i = 0; i < baris2; i++)
            {
                temp = "";
                for (int j = 0; j < kolom2; j++)
                {
                    temp = temp + arrMatriks2[i, j] + "\t";
                }
                lstOut2.Items.Add(temp);
            }
        }

        private void btnPenjumlahan_Click(object sender, EventArgs e)
        {
            lstHasil.Items.Clear();
            int baris = (int)nudJumBaris.Value;
            int kolom = (int)nudJumKolom.Value;
            int[,] arrHasilPenjumlahan = new int[baris,kolom];

            string temp;
            for (int i = 0; i < baris; i++)
            {
                temp = "";
                for (int j = 0; j < kolom; j++)
                {
                    arrHasilPenjumlahan[i, j] = arrMatriks1[i, j] + arrMatriks2[i, j];
                    temp = temp + arrHasilPenjumlahan[i, j] + "\t";
                }
                lstHasil.Items.Add(temp);
            }
        }

        private void btnTranspose_Click(object sender, EventArgs e)
        {
            lstHasil.Items.Clear();
            //jumlah baris matriks 1 = jumlah kolom matriks transpose, dan sebaliknya       
            int baris = (int)nudJumKolom.Value;
            int kolom = (int)nudJumBaris.Value;

            int[,] arrTranspose = new int[baris,kolom];
            string temp;
            for (int i = 0; i < baris; i++)
            {
                temp = "";
                for (int j = 0; j < kolom; j++)
                {
                    arrTranspose[i, j] = arrMatriks1[j, i];
                    temp = temp + arrTranspose[i, j] + "\t";
                }
                lstHasil.Items.Add(temp);
            }
        }

        private void btnProses1_Click(object sender, EventArgs e)
        {
            lstOut1.Items.Clear();
            //masukkan isi nilai ke dalam array
            int baris = int.Parse(cmbBaris1.Text);
            int kolom = int.Parse(cmbKolom1.Text);
            int nilai = (int)nudIsiMatriks1.Value;
            arrMatriks1[(baris-1), (kolom-1)] = nilai;

            string temp;
            for (int i =0; i < baris1; i++)
            {
                temp = "";
                for (int j = 0; j < kolom1; j++)
                {
                    temp = temp + arrMatriks1[i, j] + "\t";
                }
                lstOut1.Items.Add(temp);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            baris1 = (int)nudJumBaris.Value;
            kolom1 = (int)nudJumKolom.Value;

            baris2 = (int)nudJumBaris.Value;
            kolom2 = (int)nudJumKolom.Value;

            arrMatriks1 = new int[baris1, kolom1];
            arrMatriks2 = new int[baris2, kolom2];
            //simpan array ke listbox 1
            string temp1;
            for (int i = 0; i < baris1; i++)
            {
                temp1 = "";
                for (int j = 0; j < kolom1; j++)
                {
                    temp1 = temp1 + arrMatriks1[i, j] + "\t";
                }
                lstOut1.Items.Add(temp1);
            }
            //simpan array ke listbox 2
            string temp2;
            for (int i = 0; i < baris2; i++)
            {
                temp2 = "";
                for (int j = 0; j < kolom2; j++)
                {
                    temp2 = temp2 + arrMatriks2[i, j] + "\t";
                }
                lstOut2.Items.Add(temp2 + "\t");
            }
            for (int i = 1; i <=baris1; i++)
            {
                cmbBaris1.Items.Add(i);
                cmbBaris2.Items.Add(i);
            }
            for (int i = 1; i <= kolom1; i++)
            {
                cmbKolom1.Items.Add(i);
                cmbKolom2.Items.Add(i);
            }
        }
    }
}
