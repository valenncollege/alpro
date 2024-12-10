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
    public partial class Latihan_1 : Form
    {
        public Latihan_1()
        {
            InitializeComponent();
        }

        private void Hitung(int pPanjang, int pLebar, out int pKeliling, out int pluas)
        {
            pKeliling = 2 * (pLebar + pPanjang);
            pluas = pLebar * pPanjang;       
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int panjang = int.Parse(txtPanjang.Text);
            int lebar = int.Parse(txtLebar.Text);
            int luas, keliling;
            Hitung(panjang, lebar, out keliling, out luas);
            lstOut.Items.Add("Keliling = " + keliling);
            lstOut.Items.Add("Luas = " + luas);

        }
    }
}
