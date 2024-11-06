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
    public partial class Latihan_A : Form
    {
        public Latihan_A()
        {
            InitializeComponent();
        }

        int[] arrNilai = new int[30];
        int jumlahNilaiInput = 0;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int nilai = (int)nudNilai.Value;
            arrNilai[jumlahNilaiInput] = nilai;

            jumlahNilaiInput++;

            lstHasil.Items.Add("Nilai mhs "+ jumlahNilaiInput + " : "+ nilai);

            MessageBox.Show("Nilai telah tersimpan");
        }

        private void Latihan_A_Load(object sender, EventArgs e)
        {

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            lstHasil.Items.Clear();

            lstHasil.Items.Add("Daftar Nilai Mahasiswa");
            for (int i = 0; i < jumlahNilaiInput; i++)
            {
                lstHasil.Items.Add("Nilai mhs " + (i+1)  + ": " + arrNilai[i]);
            }

        }

        private void btnRatarata_Click(object sender, EventArgs e)
        {
            lstHasil.Items.Clear();
            double total = 0;
            for (int i = 0; i < jumlahNilaiInput; i++)
            {
                total = total + arrNilai[i];
            }

            double rata = total / jumlahNilaiInput;
            for (int j= 0; j < jumlahNilaiInput; j++)
            {
                lstHasil.Items.Add("Nilai mhs " + (j + 1) + ": " + arrNilai[j]);
            }
            lstHasil.Items.Add("Rata2 Nilai Mahasiswa = " + rata);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            lstHasil.Items.Clear();
            int min = 100;
            int min2=0;
            for (int i = 0; i < jumlahNilaiInput; i++)
            {
                if (min > arrNilai[i])
                {
                    min = arrNilai[i];
                }
            }
            for (int i = 0; i < jumlahNilaiInput; i++)
            {
                if (min == arrNilai[i])
                {
                    min2 = i + 1;
                }
            }

            for (int i = 0; i < jumlahNilaiInput; i++)
            {
                lstHasil.Items.Add("Nilai mhs " + (i + 1) + ": " + arrNilai[i]);
            }
            lstHasil.Items.Add("Nilai min mahasiswa : " + min);
            lstHasil.Items.Add("Beliau adalah mhs ke-" + min2);

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            lstHasil.Items.Clear();
            int max = 0;
            for (int i = 0; i < jumlahNilaiInput; i++)
            {
                if (max < arrNilai[i])
                {
                    max = arrNilai[i];
                }
            }
            for (int i = 0; i < jumlahNilaiInput; i++)
            {
                lstHasil.Items.Add("Nilai mhs " + (i + 1) + ": " + arrNilai[i]);
            }
            lstHasil.Items.Add("Nilai min mahasiswa : " + max);
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            int remidi = 0;
            int beliau=0;
            for (int i = 0; i <jumlahNilaiInput; i++)
            {
                if(arrNilai[i] < 55)
                {
                    beliau = i + 1;
                    lstHasil.Items.Add("Mhs ke " + beliau +" tidak lulus karena mendapat nilai "+ arrNilai[i]);
                    remidi++;
                }
            }
            lstHasil.Items.Add("Jumlah mhs yg di bawah 55 : " + remidi);

            

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int min, indekmin;

            for (int j = 0; j < jumlahNilaiInput-1; j++)
            {
                min = arrNilai[j];
                indekmin = j;

                for (int i = j+1; i < jumlahNilaiInput; i++)
                {
                    if (min > arrNilai[i])
                    {
                        min = arrNilai[i];
                        indekmin = 1;
                    }
                }
                //tukar
                int temp = arrNilai[j];
                arrNilai[j] = arrNilai[indekmin];
                arrNilai[indekmin] = temp;
            }
        }
    }
}
