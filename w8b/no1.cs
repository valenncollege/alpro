using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_W8B
{
    public partial class no1 : Form
    {
        public no1()
        {
            InitializeComponent();
        }

        private void lblKota_Click(object sender, EventArgs e)
        {

        }

        private void cmbKota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = "Nama : " + txtNama.Text;
            string kota = "Kota Asal : " + cmbKota.Text;
            string jenisKelamin="";
            if (rdoPria.Checked == true)
            {
                jenisKelamin = "Pria";
            }
            if (rdoWanita.Checked == true)
            {
                jenisKelamin = "Wanita";
            }
            MessageBox.Show(nama + "\n" + kota + "\n" + "Jenis Kelamin : " + jenisKelamin + "\n" + "Selamat, data anda berhasil disimpan !");
        }
        private void rdoPria_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void boxJenisKelamin_Enter(object sender, EventArgs e)
        {

        }

        private void nudUsia_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
