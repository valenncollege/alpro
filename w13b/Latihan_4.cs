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
    public partial class Latihan_4 : Form
    {
        public Latihan_4()
        {
            InitializeComponent();
        }

        private void HitungFaktor(int pNumber)
        {
            int faktorial = 1;
            for (int i = 2; i <= pNumber; i++)
            {
                faktorial = faktorial * i; 
            }
            lstOut.Items.Add(pNumber + "!" + " = " + faktorial);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumber.Text);
            HitungFaktor(number);
        }
    }
}
