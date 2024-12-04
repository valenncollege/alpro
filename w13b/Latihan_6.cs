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
    public partial class Latihan_6 : Form
    {
        public Latihan_6()
        {
            InitializeComponent();
        }

        private void Tampil(int pNumber)
        {
            int hasil;
            for (int i = 1; i <= 10; i++)
            {
                hasil = pNumber * i;
                lstOut.Items.Add(pNumber + " x " + i + " = " + hasil);
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumber.Text);
            Tampil(number);
        }
    }
}
