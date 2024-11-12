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
    public partial class latihan_5 : Form
    {
        public latihan_5()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //buat variabel array
        int[] arrNRP = new int[30];
        int[] arrNTS = new int[30];
        int[] arrNAS = new int[30];
        int index = 0;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int nrp = int.Parse(txtNRP.Text);
            int nts = (int)nudNTS.Value;
            int nas = (int)nudNAS.Value;

            arrNRP[index] = nrp;

            arrNTS[index] = nts;
            arrNAS[index] = nas;

            index++;

            txtNRP.Clear();
            nudNTS.ResetText();
            nudNAS.ResetText();
            txtNRP.Select();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            double na = 0;
            for (int i = 0; i < index; i++)
            {
                na = (0.4 * arrNTS[i]) + (0.6 * arrNAS[i]);
                lstOut.Items.Add("Mahasiswa " + arrNRP[i] + " mendapat NA : " + na);
            }
        }

        private void btnTampilNTS_Click(object sender, EventArgs e)
        {
            //hitung rata-rata
            int total = 0;
            for (int i = 0; i < index; i++)
            {
                total = total + arrNTS[i];
            }
            double rata = total / index;
            rata = Math.Round(rata, 2);
            lstOut.Items.Add("Rata-rata NTS seluruh mahasiswa : " + rata);

            //hitung nilai terendah dan tertinggi
            int min = arrNTS[0], max = arrNTS[0];
            for (int i = 1; i < index; i++)
            {
                if (min > arrNTS[i])
                {
                    min = arrNTS[i];
                }
                else if (max < arrNTS[i])
                {
                    max = arrNTS[i];
                }
            }
            lstOut.Items.Add("Nilai NTS terendah = " + min);
            lstOut.Items.Add("Nilai NTS tertinggi = " + max);
        }

        private void btnTampilNAS_Click(object sender, EventArgs e)
        {
            //hitung rata-rata
            int total = 0;
            for (int i = 0; i < index; i++)
            {
                total = total + arrNAS[i];
            }
            double rata = total / index;
            rata = Math.Round(rata, 2);
            lstOut.Items.Add("Rata-rata NAS seluruh mahasiswa : " + rata);

            //hitung nilai terendah dan tertinggi
            int min = arrNAS[0], max = arrNAS[0];
            for (int i = 1; i < index; i++)
            {
                if (min > arrNAS[i])
                {
                    min = arrNAS[i];
                }
                else if (max < arrNAS[i])
                {
                    max = arrNAS[i];
                }
            }
            lstOut.Items.Add("Nilai NAS terendah = " + min);
            lstOut.Items.Add("Nilai NAS tertinggi = " + max);
        }

        private void btnTdkLulus_Click(object sender, EventArgs e)
        {
            lstOut.Items.Add("Berikut mahasiswa yang tidak lulus :");
            double na = 0;
            for (int i = 0; i < index; i++)
            {
                na = (0.4 * arrNTS[i]) + (0.6 * arrNAS[i]);
                na = Math.Round(na, 2);
                //menampilkan mahasiswa yang na di bawah 55
                if (na < 55)
                {
                    lstOut.Items.Add(arrNRP[i]);
                    lstOut.Items.Add("NTS : " + arrNTS[i]);
                    lstOut.Items.Add("NAS : " + arrNAS[i]);
                    lstOut.Items.Add("NA : " + na);
                    lstOut.Items.Add("");
                }
            }
        }

        private void btnTertinggi_Click(object sender, EventArgs e)
        {
            double[] arrNA = new double[30];
            double na=0;
            
            for (int i = 0; i < index; i++)
            {
                na = (0.4 * arrNTS[i]) + (0.6 * arrNAS[i]);
                na = Math.Round(na, 2);
                arrNA[i] = na;
            }

            for (int i = 0; i < index-1; i++)
            {
                for (int j = i+1; j<index; j++)
                {
                    if (arrNA[i] < arrNA[j])
                    {
                        //menukar na
                        double temp = arrNA[i];
                        arrNA[i] = arrNA[j];
                        arrNA[j] = temp;
                        //menukar nrp
                        int tempNrp = arrNRP[i];
                        arrNRP[i] = arrNRP[j];
                        arrNRP[j] = tempNrp;
                    }
                }
                
            }
            lstOut.Items.Add("Berikut daftar mahasiswa dengan nilai tertinggi : ");
            //menampilkan data yang sudah terurut
            for (int i = 0; i < index; i++)
            {
                lstOut.Items.Add("Mahasiswa " + arrNRP[i] + " mendapatkan nilai : " +arrNA[i]);
            }
            
        }

        private void btnNisbi_Click(object sender, EventArgs e)
        {
            double na = 0;
            int a=0, b=0, c=0, d=0, _e=0;
            for (int i = 0; i < index; i++)
            {
                na = (0.4 * arrNTS[i]) + (0.6 * arrNAS[i]);
                if (na > 81)
                {
                    a++;
                }
                else if (na >= 66 && na < 81)
                {
                    b++;
                }
                else if (na >= 55 && na < 66)
                {
                    c++;
                }
                else if (na >= 40 && na < 55)
                {
                    d++;
                }
                else
                {
                    _e++;
                }
            }
                //menentukan presentasi masing-masing nisbi
                double persenA = (double)((double)a / index) * 100;
                double persenB =(double)((double)b / index) * 100;
                double persenC =(double)((double)c / index) * 100;
                double persenD = (double)((double)d / index) * 100;
                double persenE = (double)((double)_e / index) * 100;
            lstOut.Items.Add("A = " + persenA + "%");
            lstOut.Items.Add("B = " + persenB + "%");
            lstOut.Items.Add("C = " + persenC + "%");
            lstOut.Items.Add("D = " + persenD + "%");
            lstOut.Items.Add("E = " + persenE + "%");
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            //cek apakah textbox nrp diisi atau kosong
            if (string.IsNullOrWhiteSpace(txtNRP.Text))
            {
                lstOut.Items.Add("Input NRP dulu");
            }
            else
            {
                int nrp = int.Parse(txtNRP.Text);

                double na = 0;

                for (int i = 0; i < index; i++)
                {
                    if (arrNRP[i] == nrp)
                    {
                        na = (0.4 * arrNTS[i]) + (0.6 * arrNAS[i]);
                        //mencari nas perbaikan jika na dibawah 55
                        if (na < 55)
                        {
                            double nasPerbaikan = ((55 - (0.4 * arrNTS[i])) / 0.6);
                            nasPerbaikan = Math.Round(nasPerbaikan, 2);
                            lstOut.Items.Add("Nilai perbaikan NAS : " + nasPerbaikan);
                        }
                        else
                        {
                            lstOut.Items.Add("NA anda sudah mencapai minimal kelulusan");
                        }
                    }
                }
            }
        }
    }
}
