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
    public partial class Exercise2 : Form
    {
        public Exercise2()
        {
            InitializeComponent();
        }
        List<string> listNama = new List<string>();
        List<int> listNTS = new List<int>();
        List<int> listNAS = new List<int>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            int nts = (int)nudMidExamMark.Value;
            int nas = (int)nudFinalExamMark.Value;
            string name = txtName.Text;

            listNTS.Add(nts);
            listNAS.Add(nas);
            listNama.Add(name);

            lstOut.Items.Add(name + " : NTS = " + nts + ", NAS = " + nas);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //berapa nilai yg disimpan
            lstOut.Items.Add("Jumlah mahasiswa = " + listNAS.Count);

            //hitung rata nilai akhir
            double na, total = 0;
            for (int i = 0; i < listNTS.Count; i++)
            {
                na = (0.4 * listNTS[i]) + (0.6 * listNAS[i]);
                total = total + na;
            }
            double rata = total / listNTS.Count;
            lstOut.Items.Add("Rata-rata NA = " + rata);

            //tentukan nama dan na yg di bawah rata-rata
            lstOut.Items.Add("Berikut nama yang di bawah rata-rata");
            for (int i = 0; i < listNTS.Count; i++)
            {
                na = (0.4 * listNTS[i]) + (0.6 * listNAS[i]);
                if(na < rata)
                {
                    lstOut.Items.Add(listNama[i] + "=" + na);
                }
            }
            //tentukan nama dan na siswa na tertinggi
            lstOut.Items.Add("Berikut nama yang mendapat na tertinggi dan terendah");
            double max = 0, min = 100;
            for (int i = 0; i < listNama.Count; i++)
            {
                na = (0.4 * listNTS[i]) + (0.6 * listNAS[i]);
                if(max < na)
                {
                    max = na;
                }
                else if (min > na)
                {
                    min = na;
                }
            }
            for (int i = 0; i < listNama.Count; i++)
            {
                na = (0.4 * listNTS[i]) + (0.6 * listNAS[i]);
                if (max == na)
                {
                    lstOut.Items.Add("Mahasiswa nilai tertinggi = " + listNama[i] + " = " + na);
                }
            }
            for (int i = 0; i < listNama.Count; i++)
            {
                na = (0.4 * listNTS[i]) + (0.6 * listNAS[i]);
                if (min == na)
                {
                    lstOut.Items.Add("Mahasiswa nilai terendah = " + listNama[i] + " = " + na);
                }
            }

        }
    }
}
