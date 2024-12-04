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
    public partial class Latihan_5 : Form
    {
        public Latihan_5()
        {
            InitializeComponent();
        }

        private double HitungDiskon(int pPurchase)
        {
            double diskon = 0;
            if (pPurchase < 1000000)
            {
                diskon = 0;
            }
            else
            {
                diskon = 0.1 * pPurchase;
            }
            double total = pPurchase - diskon;
            return total;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int purchase = int.Parse(txtTotal.Text);
            lstOut.Items.Add("Total Purchase = Rp " + purchase);
            lstOut.Items.Add("Total Purchase after Discount = Rp " + HitungDiskon(purchase));
        }
    }
}
