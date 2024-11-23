using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W11B_Jevon_Valentino_160424066
{
    public partial class Exercise1 : Form
    {
        public Exercise1()
        {
            InitializeComponent();
        }
        List<int> listNilai = new List<int>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            int nilai = (int)nudExamMark.Value;

            listNilai.Add(nilai);

            lstOut.Items.Add(nilai);

            nudExamMark.Value = nudExamMark.Minimum;
            nudExamMark.Focus();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            lstOut.Items.Add("Jumlah mahasiswa = " + listNilai.Count);

            //rata-rata
            double total = 0;
            foreach(int nilai in listNilai)
            {
                total = total + nilai;
            }
            double rata = total / listNilai.Count;
            lstOut.Items.Add("rata-rata nilai = " + rata);

            //tentukan banyak yg di bawah rata-rata
            int under=0;
            foreach (int nilai in listNilai)
            {
                if (nilai < rata)
                {
                    under++;
                }
            }
            lstOut.Items.Add("Di bawah rata-rata = " + under);

            //nilai tertinggi dan terendah
            int max = listNilai[0], min = listNilai[0];

            for (int i = 1; i < listNilai.Count; i++)
            {
                if (max < listNilai[i])
                {
                    max = listNilai[i];
                }
                else if (min > listNilai[i])
                {
                    min = listNilai[i];
                }
            }
            lstOut.Items.Add("Nilai tertinggi = " + max);
            lstOut.Items.Add("Nilai terendah = " + min);




        }
    }
}
