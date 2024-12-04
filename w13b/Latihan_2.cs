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
    public partial class Latihan_2 : Form
    {
        public Latihan_2()
        {
            InitializeComponent();
        }

        private string Check(string pNumber)
        {
            string bilangan;
            bool cekNum = int.TryParse(pNumber, out int hasil);
            if (!cekNum)
            {
                bilangan = "Incorrect input detected!";
            }
            else
            {
                if (hasil > 0)
                {
                    bilangan = "Positive number";
                }
                else if (hasil < 0)
                {
                    bilangan = "Negative number";
                }
                else
                {
                    bilangan = "Zero number";
                }
            }
            return bilangan;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string nilai = txtNumber.Text;
            lblAnswer.Text = Check(nilai);
        }
    }
}
