using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W13B_Jevon_Valentino_160424066
{
    public partial class Latihan_7 : Form
    {
        public Latihan_7()
        {
            InitializeComponent();
        }
        List<int> listNilai = new List<int>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            int nilai = int.Parse(txtNilai.Text);
            listNilai.Add(nilai);

            MessageBox.Show("Data added successfully.", "", MessageBoxButtons.OK);
            txtNilai.Clear();
            txtNilai.Focus();
        }

        private double HitungRata(List<int> pList)
        {
            double rata = 0;
            double total = 0;
            for (int i = 0; i < pList.Count; i++)
            {
                total = total + pList[i];
            }
            rata = total / pList.Count;
            rata = Math.Round(rata, 2);
            return rata;
        }

        private void AboveAverage(List<int> pList)
        {
            for (int i = 0; i < pList.Count-1; i++)
            {
                if (pList[i] > HitungRata(listNilai))
                {
                    lstOut.Items.Add(pList[i]);
                }
            }
        }

        private void btnAboveAverage_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
            double rata = HitungRata(listNilai);
            lstOut.Items.Add("Average Mark = " + rata);
            lstOut.Items.Add("Student mark above average:");
            AboveAverage(listNilai);
        }

        private void UnderAverage(List<int> pList)
        {
            for (int i = 0; i < pList.Count; i++)
            {
                if (pList[i] < 55)
                {
                    lstOut.Items.Add(pList[i]);
                }
            }
        }

        private void btnUnder55_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
            lstOut.Items.Add("Student mark under 55 : ");
            UnderAverage(listNilai);
        }
    }
}
