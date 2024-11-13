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
    public partial class latihan : Form
    {
        public latihan()
        {
            InitializeComponent();
        }

        int[,] arrNilai;
        int baris, kolom;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            baris = (int)nudJumlahMhs.Value;
            kolom = (int)nudJumlahTugas.Value;

            arrNilai = new int[baris, kolom];

            string temp;
            for (int i = 0; i < baris; i++)
            {
                temp = "";
                for (int j = 0; j < kolom; j++)
                {
                    temp = temp + arrNilai[i, j];
                }
                lstOut.Items.Add(temp);
            }

            for (int i = 1; i <= baris; i++)
            {
                cmbInputMhs.Items.Add(i);
            }
            for (int i = 1; i <= kolom; i++)
            {
                cmbInputTugas.Items.Add(i);
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
            int noBaris = int.Parse(cmbInputMhs.Text);
            int noKolom = int.Parse(cmbInputTugas.Text);
            int nilai = (int)nudInputNilai.Value;
            arrNilai[(noBaris - 1), (noKolom - 1)] = nilai;

            string temp;
            for (int i = 0; i < baris; i++)
            {
                temp = "";
                for (int j = 0; j < kolom; j++)
                {
                    temp = temp + arrNilai[i, j] + "\t";
                }
                lstOut.Items.Add(temp);
            }

        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            int max;
            double rata;
            if (rdoTertinggi.Checked && rdoMhs.Checked)
            {
                for (int i = 0; i < baris; i++)
                {
                    max = arrNilai[i, 0];
                    for (int j = 0; j < kolom; j++)
                    {
                        if (max < arrNilai[i, j])
                        {
                            max = arrNilai[i, j];
                        }
                    }
                    lstOut.Items.Add("Nilai tertinggi mhs ke " + (i + 1) + " = " + max);
                }
            }
            else if (rdoTertinggi.Checked && rdoTugas.Checked)
            {
                for (int i = 0; i < kolom; i++)
                {
                    max = arrNilai[0, i];
                    for (int j = 0; j < baris; j++)
                    {
                        if (max < arrNilai[j, i])
                        {
                            max = arrNilai[j, i];
                        }
                    }
                    lstOut.Items.Add("Nilai tertinggi tugas ke " + (i + 1) + " = " + max);
                }
            }

            else if (rdoRataRata.Checked && rdoTugas.Checked)
            {
                for (int i = 0; i < kolom; i++)
                {
                    rata = 0;
                    for (int j = 0; j < baris; j++)
                    {
                        rata = rata + arrNilai[j, i];
                    }
                    rata = rata / baris;
                    rata = Math.Round(rata, 2);
                    lstOut.Items.Add("Rata - rata nilai tugas ke- " + (i + 1) + " = " + rata);
                }
            }
            else
            {
                for (int i = 0; i < baris; i++)
                {
                    rata = 0;
                    for (int j = 0; j < kolom; j++)
                    {
                        rata = rata + arrNilai[i,j];
                    }
                    rata = rata / baris;
                    rata = Math.Round(rata, 2);
                    lstOut.Items.Add("Rata - rata nilai mhs ke- " + (i + 1) + " = " + rata);
                }
            }
        }
    

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
