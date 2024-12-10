using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W14A_Jevon_Valentino_160424066
{
    public partial class Latihan_2 : Form
    {
        public Latihan_2()
        {
            InitializeComponent();
        }

        private int Hitung(int pTahunLahir, int pTahunIni)
        {
            int hasil = pTahunIni - pTahunLahir;
            return hasil;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int tahunLahir = int.Parse(txtTahun.Text);
            int tahunIni = DateTime.Now.Year;
            lstOut.Items.Add("Usia anda : " + Hitung(tahunLahir, tahunIni));
        }
    }
}
