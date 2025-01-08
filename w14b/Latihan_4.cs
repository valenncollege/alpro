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
    public partial class Latihan_4 : Form
    {
        public Latihan_4()
        {
            InitializeComponent();
        }

        List<string> listNama = new List<string>();
        List<string> listJenisDokter = new List<string>();
        List<int> listBiayaLain = new List<int>();
        List<int> listBiayaTotal = new List<int>();

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string nama = txtNamaPasien.Text;
            listNama.Add(nama);

            int biayaDokter;
            string jenisDokter;
            if (rdoDrUmum.Checked)
            {
                biayaDokter = 30000;
                jenisDokter = "Dr. Umum";
            }
            else if (rdoDrGigi.Checked)
            {
                biayaDokter = 40000;
                jenisDokter = "Dr. Gigi";
            }
            else
            {
                biayaDokter = 45000;
                jenisDokter = "Dr. Spesialis";
            }
            listJenisDokter.Add(jenisDokter);

            int biayaLain = int.Parse(txtBiayaLain.Text);
            listBiayaLain.Add(biayaLain);
            listBiayaTotal.Add((biayaDokter + biayaLain));
            lstOut.Items.Add("Nama Pasien = " + nama);
            lstOut.Items.Add("Dokter yang dituju = " + jenisDokter);
            lstOut.Items.Add("Biaya = " + biayaDokter + " + " + biayaLain + " = " + (biayaDokter + biayaLain));
            lstOut.Items.Add("");
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
            for (int i = 0; i < listNama.Count; i++)
            {
                lstOut.Items.Add("Nama pasien : " + listNama[i]);
                lstOut.Items.Add("Dokter dituju : " + listJenisDokter[i]);
                lstOut.Items.Add("Biaya Lainnya : " + listBiayaLain[i]);
                lstOut.Items.Add("Biaya total : " + listBiayaTotal[i]);
            }
        }

        private int HitungJumlahPasien()
        {
            int jumPasien = listNama.Count;
            return jumPasien;
        }

        private int HitungPasienDrSpesialis()
        {
            int jumPasien = 0;
            for (int i = 0; i < listJenisDokter.Count; i++)
            {
                if (listJenisDokter[i] == "Dr. Spesialis")
                {
                    jumPasien++;
                }
            }
            return jumPasien;
        }

        private int HitungPendapatanDokter()
        {
            int totalBiaya = 0;
            for (int i = 0; i < listBiayaLain.Count; i++)
            {
                totalBiaya = totalBiaya + (listBiayaTotal[i] - listBiayaLain[i]);
            }
            return totalBiaya;
        }   

        private int HitungPendapatanLain()
        {
            int totalBiaya = 0;
            for (int i = 0; i < listBiayaLain.Count; i++)
            {
                totalBiaya = totalBiaya + listBiayaLain[i];
            }
            return totalBiaya;
        }

        private double HitungRata()
        {
            int total=0;
            double rata;
            for(int i = 0; i < listBiayaLain.Count; i++)
            {
                total = total + listBiayaTotal[i];
            }
            rata = total / listBiayaTotal.Count;
            return rata;
        }

        private int HitungPasienTertinggi()
        {
            int max = listBiayaTotal[0];
            for (int i = 1; i < listBiayaLain.Count; i++)
            {
                if(max < listBiayaTotal[i])
                {
                    max = listBiayaTotal[i];
                }
            }
            return max;
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();            
            lstOut.Items.Add("Jumlah pasien yang datang = " + HitungJumlahPasien());
            lstOut.Items.Add("Jumlah pasien yang datang ke Dr Spesialis = " + HitungPasienDrSpesialis());
            lstOut.Items.Add("Total pendapatan dari jasa dokter = " + HitungPendapatanDokter());
            lstOut.Items.Add("Total pendapatan dari biaya lainnya = " + HitungPendapatanLain());
            lstOut.Items.Add("Rata-rata pendapatan per pasien = " + HitungRata());
            lstOut.Items.Add("Pasien dengan total biaya tertinggi = " + HitungPasienTertinggi());
        }
    }
}
