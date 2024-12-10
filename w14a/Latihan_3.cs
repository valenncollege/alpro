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
    public partial class Latihan_3 : Form
    {
        public Latihan_3()
        {
            InitializeComponent();
        }

        private void HitungDiskon(string pMetodeBayar, int pBiaya, out double pTotalDiskon, out double pTotalBayar)
        {
            if (pMetodeBayar == "Cash")
            {
                pTotalDiskon = 0;
            }
            else if (pMetodeBayar == "Credit")
            {
                pTotalDiskon = pBiaya * 0.1;
                
            }
            else if (pMetodeBayar == "OVO")
            {
                pTotalDiskon = pBiaya * 0.4;
                if (pTotalDiskon > 40000)
                {
                    pTotalDiskon = 40000;
                }
            }
            else
            {
                pTotalDiskon = 0.25 * pBiaya;
                if (pTotalDiskon > 90000)
                {
                    pTotalDiskon = 90000;
                }
            }
            pTotalBayar = pBiaya - pTotalDiskon;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int totalBiaya = int.Parse(txtTotalBelanja.Text);
            string metodeBayar = "";
            if (rdoCredit.Checked)
            {
                metodeBayar = "Credit";
            }
            if (rdoGopay.Checked)
            {
                metodeBayar = "Gopay";
            }
            if (rdoOvo.Checked)
            {
                metodeBayar = "OVO";
            }
            if (rdoCash.Checked)
            {
                metodeBayar = "Cash";
            }
            double totalBayar, totalDiskon;
            HitungDiskon(metodeBayar, totalBiaya, out totalDiskon, out totalBayar);
            lstOut.Items.Add("Total diskon = Rp " + totalDiskon);
            lstOut.Items.Add("Total bayar setelah diskon = Rp " + totalBayar);
        }
    }
}
