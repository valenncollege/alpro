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
    public partial class Latihan_3 : Form
    {
        public Latihan_3()
        {
            InitializeComponent();
        }

        private int Hitung(int pNumber)
        {
            int nilai = 0;
            while(pNumber > 0)
            {
                nilai = nilai + pNumber % 10;
                pNumber = pNumber / 10;
            }
            return nilai;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            bool check = int.TryParse(txtNumber.Text, out int number);
            if (!check)
            {
                lblResult.Text = "Error, cannot process the input!";
            }
            else
            {
                lblResult.Text = Hitung(number).ToString();
            }
        }
    }
}
